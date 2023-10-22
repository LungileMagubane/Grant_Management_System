using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Grant_Management_System.Data;
using Grant_Management_System.Models;
using System.ComponentModel;
using System.Reflection;
using Grant_Management_System.Data.Migrations;
using Grant_Management_System.Models.DropdownMenus;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Grant_Management_System.Controllers
{
    public class GrantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GrantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Grant Grant { get; set; }
        public SelectList Departments { get; set; }
        public SelectList Durations { get; set; }
        public SelectList Faculties { get; set; }
        public SelectList FundingProgrammes { get; set; }
        public SelectList Genders { get; set; }
        public SelectList Races { get; set; }
        public SelectList Titles { get; set; }
        public SelectList StatusOfGrants { get; set; }

        // quering the database based on the selected dropdowns
        public async Task<IActionResult> GetDepartmentbyTV()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new{
             Department = group.Key, TotalSum = group.Sum(r => r.TotalGrantValue), Count = group.Count()}).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})") .ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
     
        public async Task<IActionResult> GetDepartmentbyAm1()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new {
                Department = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear1),
                Count = group.Count()
            }).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})").ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetDepartmentbyAm2()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new {
                Department = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear2),
                Count = group.Count()
            }).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})").ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetDepartmentbyAm3()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new {
                Department = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear3),
                Count = group.Count()
            }).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})").ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetDepartmentbyAm4()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new {
                Department = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear4),
                Count = group.Count()
            }).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})").ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetDepartmentbyAm5()
        {
            List<object> data = new List<object>();
            var departmentGroups = _context.grants.GroupBy(r => r.Department.Name).Select(group => new {
                Department = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear5),
                Count = group.Count()
            }).ToList();

            List<string> labels = departmentGroups.Select(result => $"{result.Department} ({result.Count})").ToList();
            List<decimal> totalV = departmentGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }


        public async Task<IActionResult> GetGenderbyTV()
        {
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
               Gender = group.Key,
                TotalSum = group.Sum(r => r.TotalGrantValue),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetGenderbyAm1()
        {
            
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
                Gender = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear1),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetGenderbyAm2()
        {
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
              Gender = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear2),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetGenderbyAm3()
        {
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
               Gender = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear3),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetGenderbyAm4()
        {
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
               Gender = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear4),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetGenderbyAm5()
        {
            List<object> data = new List<object>();
            var genderGroups = _context.grants.GroupBy(r => r.Gender.Name).Select(group => new {
               Gender = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear5),
                Count = group.Count()
            }).ToList();

            List<string> labels = genderGroups.Select(result => $"{result.Gender} ({result.Count})").ToList();
            List<decimal> totalV = genderGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetFacultybyTV()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
               Chart = group.Key,
                TotalSum = group.Sum(r => r.TotalGrantValue),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetFacultybyAm1()
        {

            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
               Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear1),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFacultybyAm2()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear2),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFacultybyAm3()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear3),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFacultybyAm4()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear4),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFacultybyAm5()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Faculty.Name).Select(group => new {
               Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear5),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetRacebyTV()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.TotalGrantValue),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetRacebyAm1()
        {

            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear1),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetRacebyAm2()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear2),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetRacebyAm3()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear3),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetRacebyAm4()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear4),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetRacebyAm5()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.Race.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear5),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetFundsbyTV()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.TotalGrantValue),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        public async Task<IActionResult> GetFundsbyAm1()
        {

            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear1),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFundsbyAm2()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear2),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFundsbyAm3()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear3),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFundsbyAm4()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear4),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }
        public async Task<IActionResult> GetFundsbyAm5()
        {
            List<object> data = new List<object>();
            var chartGroups = _context.grants.GroupBy(r => r.FundingProgramme.Name).Select(group => new {
                Chart = group.Key,
                TotalSum = group.Sum(r => r.AmountInYear5),
                Count = group.Count()
            }).ToList();

            List<string> labels = chartGroups.Select(result => $"{result.Chart} ({result.Count})").ToList();
            List<decimal> totalV = chartGroups.Select(result => result.TotalSum).ToList();

            data.Add(labels);
            data.Add(totalV);

            return Json(data);
        }

        // GET: Grants
        public async Task<IActionResult> Index()
        {
            

            var grants = from g in _context.grants.Include(g => g.Department).Include(g => g.Duration).Include(g => g.Faculty).Include(g => g.FundingProgramme).Include(g => g.Gender).Include(g => g.Race).Include(g => g.Title).Include(g=>g.StatusOfGrant)
                         select g;

          

            var applicationDbContext = _context.grants.Include(g => g.Department).Include(g => g.Duration).Include(g => g.Faculty).Include(g => g.FundingProgramme).Include(g => g.Gender).Include(g => g.Race).Include(g => g.Title).Include(g=>g.StatusOfGrant);
            return View(await applicationDbContext.AsNoTracking().ToListAsync());
           
           // return View();
        }

        // GET: Grants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grant = await _context.grants
                .Include(g => g.Department)
                .Include(g => g.Duration)
                .Include(g => g.Faculty)
                .Include(g => g.FundingProgramme)
                .Include(g => g.Gender)
                .Include(g => g.Race)
                .Include(g => g.Title)
                .Include(g=>g.StatusOfGrant)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grant == null)
            {
                return NotFound();
            }

            return View(grant);
        }

        // GET: Grants/Create
        public async Task <IActionResult>Create()
        {

             await LoadInitialData();
            return View();
        }
        public async Task LoadInitialData()
        {
            ViewData["DepartmentID"] = new SelectList(_context.departments, "Id", "Name");
            ViewData["DurationID"] = new SelectList(_context.durations, "Id", "Name");
            ViewData["FacultyID"] = new SelectList(_context.faculties, "Id", "Name");
            ViewData["FundingProgrammeID"] = new SelectList(_context.fundingProgrammes, "Id", "Name");
            ViewData["GenderID"] = new SelectList(_context.genders, "Id", "Name");
            ViewData["RaceID"] = new SelectList(_context.races, "Id", "Name");
            ViewData["TitleID"] = new SelectList(_context.titles, "Id", "Name");
            ViewData["StatusOfGrantID"] = new SelectList(_context.statusOfGrants, "Id", "Name");
            
        }


        //Get:Grants/Report
        public IActionResult Report()
        {

           

            return View();
        }
        //Get: Dropdowns
        public IActionResult Dropdowns()
        {
            return View();
        }




        // POST: Grants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NameOfGrant,NameOfFunder,StatusOfGrantID,YearOfApplication,FundingProgrammeID,ResearchKeywords,DurationID,GrantYearStart,GrantYearEnd,TotalGrantValue,AmountInYear1,AmountInYear2,AmountInYear3,AmountInYear4,AmountInYear5,StaffNumber,TitleID,Initials,FirstNames,LastName,GenderID,RaceID,EmailAddress,FacultyID,DepartmentID,Nationality,Id")] Grant grant)
        {
            try
            {

                if (ModelState.IsValid)
            {
                   
                _context.Add(grant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                await LoadInitialData();

            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
        
            return View(grant);
        }


        // GET: Grants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
              var grant = await _context.grants.FindAsync(id);
            if (grant == null)
            {
                return NotFound();
            }
            await LoadInitialData();
           
            return View(grant);
        }

        // POST: Grants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, byte[] rowVersion, [Bind("NameOfGrant,NameOfFunder,StatusOfGrantID,YearOfApplication,FundingProgrammeID,ResearchKeywords,DurationID,GrantYearStart,GrantYearEnd,TotalGrantValue,AmountInYear1,AmountInYear2,AmountInYear3,AmountInYear4,AmountInYear5,StaffNumber,TitleID,Initials,FirstNames,LastName,GenderID,RaceID,EmailAddress,FacultyID,DepartmentID,Nationality,Id")] Grant grant)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            await LoadInitialData();
            var grantToUpdate = await _context.grants
                .Include(g => g.Department)
                .Include(g => g.Duration)
                .Include(g => g.Faculty)
                .Include(g => g.FundingProgramme)
                .Include(g => g.Gender)
                .Include(g => g.Race)
                .Include(g => g.Title)
                .Include(g=>g.StatusOfGrant)
                
                // .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
           
            _context.Entry(grantToUpdate).Property("RowVersion").OriginalValue = rowVersion;

            if (await TryUpdateModelAsync<Grant>(
        grantToUpdate,
        "",
        g => g.NameOfGrant, g => g.NameOfFunder, g => g.YearOfApplication, g=>g.StatusOfGrantID,
        g => g.FundingProgrammeID,
         g => g.ResearchKeywords, g => g.DurationID, g => g.GrantYearStart,
          g => g.GrantYearEnd, g => g.TotalGrantValue, g => g.AmountInYear1,
        g => g.AmountInYear2, g => g.AmountInYear3, g => g.AmountInYear4
        , g => g.AmountInYear5, g => g.StaffNumber, g => g.TitleID
        , g => g.Initials, g => g.FirstNames, g => g.LastName
       , g => g.GenderID, g => g.RaceID, g => g.EmailAddress
       , g => g.FacultyID, g => g.DepartmentID, g => g.Nationality))
    {
        try
        {
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        catch (DbUpdateConcurrencyException ex)
        {
            var exceptionEntry = ex.Entries.Single();
            var clientValues = (Grant)exceptionEntry.Entity;
            var databaseEntry = exceptionEntry.GetDatabaseValues();
            if (databaseEntry == null)
            {
                ModelState.AddModelError(string.Empty,
                    "Unable to save changes. The Grant details was deleted by another user.");
            }
            else
            {
                var databaseValues = (Grant)databaseEntry.ToObject();

                if (databaseValues.NameOfGrant != clientValues.NameOfGrant)
                {
                    ModelState.AddModelError("NameOfGrant", $"Current value: {databaseValues.NameOfGrant}");
                }
                if (databaseValues.NameOfFunder != clientValues.NameOfFunder)
                {
                    ModelState.AddModelError("NameOfFunder", $"Current value: {databaseValues.NameOfFunder}");
                }
                        if (databaseValues.StatusOfGrantID != clientValues.StatusOfGrantID)
                        {
                            StatusOfGrant databasestat = await _context.statusOfGrants.FirstOrDefaultAsync(s => s.Id == databaseValues.StatusOfGrantID);
                            ModelState.AddModelError("StatusOfGrantID", $"Current value: {databasestat?.Name}");
                        }

                        if (databaseValues.YearOfApplication != clientValues.YearOfApplication)
                {
                    ModelState.AddModelError("YearOfApplication", $"Current value: {databaseValues.YearOfApplication:d}");
                }
                if (databaseValues.FundingProgrammeID != clientValues.FundingProgrammeID)
                {
                   FundingProgramme databasefund = await _context.fundingProgrammes.FirstOrDefaultAsync(f => f.Id == databaseValues.FundingProgrammeID);
                    ModelState.AddModelError("FundingProgrammeID", $"Current value: {databasefund?.Name}");
                }
                if (databaseValues.ResearchKeywords != clientValues.ResearchKeywords)
                {
                    ModelState.AddModelError("ResearchKeywords", $"Current value: {databaseValues.ResearchKeywords}");
                }
                if (databaseValues.DurationID != clientValues.DurationID)
                {
                            Duration databaseDu = await _context.durations.FirstOrDefaultAsync(d => d.Id == databaseValues.DurationID);
                            ModelState.AddModelError("DurationID", $"Current value: {databaseDu?.Name}");
                }
                if (databaseValues.GrantYearStart != clientValues.GrantYearStart)
                {
                    ModelState.AddModelError("GrantYearStart", $"Current value: {databaseValues.GrantYearStart:d}");
                }
                if (databaseValues.GrantYearEnd != clientValues.GrantYearEnd)
                {
                    ModelState.AddModelError("GrantYearEnd", $"Current value: {databaseValues.GrantYearEnd:d}");
                }
                if (databaseValues.TotalGrantValue != clientValues.TotalGrantValue)
                {
                            ModelState.AddModelError("TotalGrantValue", $"Current value: {databaseValues.TotalGrantValue:c}");
                 }
                 if (databaseValues.AmountInYear1 != clientValues.AmountInYear1)
                 {
                            ModelState.AddModelError("AmountInYear1", $"Current value: {databaseValues.AmountInYear1:c}");
                }
               if (databaseValues.AmountInYear2 != clientValues.AmountInYear2)
                {
                            ModelState.AddModelError("AmountInYear2", $"Current value: {databaseValues.AmountInYear2:c}");
               }
                        if (databaseValues.AmountInYear3 != clientValues.AmountInYear3)
                        {
                            ModelState.AddModelError("AmountInYear3", $"Current value: {databaseValues.AmountInYear3:c}");
                        }
                        if (databaseValues.AmountInYear4 != clientValues.AmountInYear4)
                        {
                            ModelState.AddModelError("AmountInYear4", $"Current value: {databaseValues.AmountInYear4:c}");
                        }
                        if (databaseValues.AmountInYear5 != clientValues.AmountInYear5)
                        {
                            ModelState.AddModelError("AmountInYear5", $"Current value: {databaseValues.AmountInYear5:c}");
                        }
                        if (databaseValues.StaffNumber != clientValues.StaffNumber)
                        {
                            ModelState.AddModelError("StaffNumber", $"Current value: {databaseValues.StaffNumber}");
                        }
                        if (databaseValues.TitleID != clientValues.TitleID)
                        {

                            Title databaseTit = await _context.titles.FirstOrDefaultAsync(t => t.Id == databaseValues.TitleID);
                            ModelState.AddModelError("TitleID", $"Current value: {databaseTit?.Name}");
                        }
                        if (databaseValues.Initials != clientValues.Initials)
                        {
                            ModelState.AddModelError("Initials", $"Current value: {databaseValues.Initials}");
                        }
                        if (databaseValues.FirstNames != clientValues.FirstNames)
                        {
                            ModelState.AddModelError("FirstNames", $"Current value: {databaseValues.FirstNames}");
                        }
                        if (databaseValues.LastName != clientValues.LastName)
                        {
                            ModelState.AddModelError("LastName", $"Current value: {databaseValues.LastName}");
                        }
                        if (databaseValues.GenderID != clientValues.GenderID)
                        {

                           Gender databaseGen = await _context.genders.FirstOrDefaultAsync(g => g.Id == databaseValues.GenderID);
                            ModelState.AddModelError("GenderID", $"Current value: {databaseGen?.Name}");
                        }
                        if (databaseValues.RaceID != clientValues.RaceID)
                        {

                            Race databaseRc = await _context.races.FirstOrDefaultAsync(r => r.Id == databaseValues.RaceID);
                            ModelState.AddModelError("RaceID", $"Current value: {databaseRc?.Name}");
                        }
                        if (databaseValues.EmailAddress != clientValues.EmailAddress)
                        {
                            ModelState.AddModelError("EmailAddress", $"Current value: {databaseValues.EmailAddress}");
                        }
                        if (databaseValues.FacultyID != clientValues.FacultyID)
                        {

                            Faculty databasefac = await _context.faculties.FirstOrDefaultAsync(f => f.Id == databaseValues.FacultyID);
                            ModelState.AddModelError("FacultyID", $"Current value: {databasefac?.Name}");
                        }
                        if (databaseValues.DepartmentID != clientValues.DepartmentID)
                        {

                           Department databasedept = await _context.departments.FirstOrDefaultAsync(d => d.Id == databaseValues.DepartmentID);
                            ModelState.AddModelError("DepartmentID", $"Current value: {databasedept?.Name}");
                        }
                        if (databaseValues.Nationality != clientValues.Nationality)
                        {
                            ModelState.AddModelError("Nationality", $"Current value: {databaseValues.Nationality}");
                        }




                        ModelState.AddModelError(string.Empty, "The record you attempted to edit "
                        + "was modified by another user after you got the original value. The "
                        + "edit operation was canceled and the current values in the database "
                        + "have been displayed. If you still want to edit this record, click "
                        + "the Save button again. Otherwise click the Back to List hyperlink.");
                grantToUpdate.RowVersion = (byte[])databaseValues.RowVersion;
                ModelState.Remove("RowVersion");
            }
        }
    }
           
            return View(grantToUpdate);
        }

        // GET: Grants/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? concurrencyError) //bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grant = await _context.grants
                .Include(g => g.Department)
                .Include(g => g.Duration)
                .Include(g => g.Faculty)
                .Include(g => g.FundingProgramme)
                .Include(g => g.Gender)
                .Include(g => g.Race)
                .Include(g => g.Title)
                .Include(g=>g.StatusOfGrant)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grant == null)
            {
                if (concurrencyError.GetValueOrDefault())
                {
                    return RedirectToAction(nameof(Index));
                }
                return NotFound();
            }
            if (concurrencyError.GetValueOrDefault())
            {
                ViewData["ConcurrencyErrorMessage"] = "The record you attempted to delete "
                    + "was modified by another user after you got the original values. "
                    + "The delete operation was canceled and the current values in the "
                    + "database have been displayed. If you still want to delete this "
                    + "record, click the Delete button again. Otherwise "
                    + "click the Back to List hyperlink.";
            }
           

            return View(grant);
        }

        // POST: Grants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Grant grant)//int id)
        {
         
            try
            {
                if (await _context.grants.AnyAsync(g => g.Id == grant.Id))
                {
                    _context.grants.Remove(grant);
                    await _context.SaveChangesAsync();

                }
            
        return RedirectToAction(nameof(Index));
        }
    catch (DbUpdateConcurrencyException /* ex */)
    {
        
        return RedirectToAction(nameof(Delete), new { concurrencyError = true, id = grant.Id});
    }
          
        }

        private bool GrantExists(int id)
        {
            return _context.grants.Any(e => e.Id == id);
        }
    }
}
