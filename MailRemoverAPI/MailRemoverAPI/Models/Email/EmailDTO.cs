using MailRemoverAPI.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailRemoverAPI.Models.Email
{
    public struct EmailDTO
    {
        public Guid Id { get; set; }

        public EmailType Type { get; set; }

        public string Token { get; set; }

        public Guid UserId { get; set; }
    }
}
