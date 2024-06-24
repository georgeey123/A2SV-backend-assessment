using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Models.Persistence;

namespace Web.Controllers;

public class TaskController
{
    private readonly ApplicationDbContext _context;

    public TaskController(ApplicationDbContext context)
    {
        _context = context;
    }

    public void GetTaskById(Task Id)
    {
        _Id = Id;
        
        
    }
}
