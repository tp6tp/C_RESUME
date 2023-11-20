using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_RESUME_DTO.CommonDTO
{
    public class SignDTO
    {
        #region 登入
        [Required(ErrorMessage ="Please enter your account")]
        public string Account { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
        #endregion


        #region 註冊
        [MaxLength(10, ErrorMessage = "帳號最多10個字")]
        [MinLength(8, ErrorMessage = "帳號最少8個字")]
        [Required(ErrorMessage = "Please enter your account")]
        public string reAccount { get; set; }


        [MaxLength(6, ErrorMessage = "帳戶名稱最多6個字")]
        [Required(ErrorMessage = "Please enter your account name")]
        public string reAccName { get; set; }


        [EmailAddress(ErrorMessage= "信箱格式錯誤")]
        [Required(ErrorMessage = "Please enter your Email")]
        public string reEmail { get; set; }


        
        [MaxLength(10, ErrorMessage = "密碼最多10個字")]
        [MinLength(8, ErrorMessage = "密碼最少8個字")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your password")]
        public string rePassword { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "密碼與確認密碼不符")]
        public string reConfirmPassword {  get; set; }
        #endregion
    }
}
