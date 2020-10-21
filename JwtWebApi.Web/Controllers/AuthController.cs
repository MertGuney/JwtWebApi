using AutoMapper;
using JwtWebApi.Business.Interfaces;
using JwtWebApi.Business.StringInfos;
using JwtWebApi.Entity.Concrete;
using JwtWebApi.Entity.Dtos.AppUserDtos;
using JwtWebApi.Entity.Token;
using JwtWebApi.Web.CustomFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JwtWebApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        public AuthController(IJwtService jwtService, IAppUserService appUserService, IMapper mapper)
        {
            _jwtService = jwtService;
            _appUserService = appUserService;
            _mapper = mapper;
        }
        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignIn(AppUserLoginDto appUserLoginDto)
        {
            var appUser = await _appUserService.FindByUserName(appUserLoginDto.UserName);
            if (appUser == null)
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                if (await _appUserService.CheckPassword(appUserLoginDto))
                {
                    var roles = await _appUserService.GetRolesByUserName(appUserLoginDto.UserName);

                    var token = _jwtService.GenerateJwt(appUser, roles);
                    JwtAccessToken jwtAccessToken = new JwtAccessToken
                    {
                        Token = token
                    };
                    return Created("", jwtAccessToken);
                }
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }
        }
        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> SignUp(AppUserAddDto appUserAddDto, [FromServices] IAppUserRoleService appUserRoleService, [FromServices] IAppRoleService appRoleService)
        {
            var appUser = await _appUserService.FindByUserName(appUserAddDto.UserName);
            if (appUser != null)
            {
                return BadRequest($"{appUserAddDto.UserName} zaten alınmış");
            }
            await _appUserService.Add(_mapper.Map<AppUser>(appUserAddDto));
            //Kullanıcıya default member rolü atama işlemi
            var user = await _appUserService.FindByUserName(appUserAddDto.UserName);
            var role = await appRoleService.FindByName(RoleInfo.Member);
            await appUserRoleService.Add(new AppUserRole
            {
                AppRoleId = role.Id,
                AppUserId = user.Id
            });
            return Created("", appUserAddDto);
        }
        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> ActiveUser()
        {
            var user = await _appUserService.FindByUserName(User.Identity.Name);
            var roles = await _appUserService.GetRolesByUserName(User.Identity.Name);

            AppUserDto appUserDto = new AppUserDto
            {
                FullName = user.FullName,
                UserName = user.UserName,
                Roles = roles.Select(I => I.Name).ToList()
            };
            return Ok(appUserDto);
        }
    }
}

