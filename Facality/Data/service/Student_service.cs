using Facality.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Facality.Data.service
{
	public class Student_service:Istudent
	{
		private readonly AppDbcontext _context;
		
		public Student_service(AppDbcontext context)
		{
			_context = context;
		}
	   public async Task<IEnumerable<Student>> GetAll()
		{
			var student=await _context.students.ToListAsync();
			return (student);
		}

		public async Task Add(Student student)
		{
			await _context.students.AddAsync(student);
			await _context.SaveChangesAsync();
		}

		public async Task<Student> GetById(int id)
		{
			var student=await _context.students.FirstOrDefaultAsync(x=>x.StudentId==id);
			return student;
		}

		public async Task Updata(int id, Student student)
		{
		    _context.students.Update(student);
			await _context.SaveChangesAsync();	
		}

		public async Task Delete(Student student)
		{
			  _context.students.Remove(student);
			await _context.SaveChangesAsync();
		}
	}
}
