using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_RESUME_Entity.SYS
{
    public class SYS_UserManager
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserManagerId { get; set; }
        public int PermissionType { get; set; }
        public byte[] EncPassword { get; set; }
        public string AccountName { get; set; }
        public string Account {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public bool ReviewStatus {  get; set; }
    }
}
