using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
	public class LoginService
	{
		private readonly SalesWebMvcContext _login;
		public LoginService(SalesWebMvcContext login)
		{
			_login = login;
		}

		//public async Task<List<LoginUser>> FindLogin(DateTime minDate, DateTime maxDate)
		//{
		//	var result = from obj in _context.SalesRecords select obj;
		//	if (minDate != null)
		//	{
		//		result = result.Where(x => x.Date >= minDate);
		//	}
		//	if (maxDate != null)
		//	{
		//		result = result.Where(x => x.Date <= maxDate);
		//	}
		//	return await result.Include(x => x.Seller).Include(x => x.Seller.Department).OrderByDescending(x => x.Date).ToListAsync();
		//}
	}
}
