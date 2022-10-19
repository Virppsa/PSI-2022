using MailRemoverAPI.Data;
using MailRemoverAPI.Entities;
using MailRemoverAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MailRemoverAPI.Services
{
    public class EmailRepositoryDB : IEmailRepository
    {
        MailRemoverDbContext _context;

        public EmailRepositoryDB(MailRemoverDbContext context)
        {
            _context = context;
        }

        public async Task<List<Email>> GetAllAsync()
        {
            return await _context.Set<Email>().AsQueryable().ToListAsync();
        }

        public async Task<Email?> GetByIdAsync(Guid Id)
        {
            var email = await _context.Set<Email>().SingleOrDefaultAsync(email => email.Id == Id);

            if (email is null)
            {
                throw new Exception($"Email not found with id ; {Id}");
            }

            return email;
        }
    }
}
