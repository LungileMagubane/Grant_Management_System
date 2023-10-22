using Grant_Management_System.Models.DropdownMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Grant_Management_System.Models.DropdownMenus;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Grant_Management_System.Models
{
    public class Grant :BaseDomaininEntity
    {
        [ Required,Display(Name = "Name of grant")]
        public string NameOfGrant { get; set; }
        [Required, Display(Name = "Name Of funder")]
        public string  NameOfFunder{ get; set; }
        [Required, Display(Name = "Status of grant")]
        public int? StatusOfGrantID { get; set; }
        [ Display(Name = "Status of grant")]
        public virtual StatusOfGrant StatusOfGrant { get; set; }
        [Required, Display(Name = "Year of application")]
        [RegularExpression(@"^20\d{2}$", ErrorMessage = "Please enter a valid year.") ]
        public string YearOfApplication { get; set; }
        [Required, Display(Name = "Funding programme")]
        public int? FundingProgrammeID { get; set; }
        [ Display(Name = "Funding programme")]
        public virtual FundingProgramme FundingProgramme { get; set; }
        [Required, Display(Name = "Research keywords")]
        public string ResearchKeywords { get; set; }
        [Required,Display(Name = "Duration")]
        public int? DurationID { get; set; }
        public virtual Duration Duration { get; set; }
        [ Required, Display(Name = "Grant year start"), ]
        [RegularExpression(@"^20\d{2}$", ErrorMessage = "Please enter a valid year.")]
        public string GrantYearStart { get; set; }
      [ Required,Display(Name = "Grant year end")]
        [RegularExpression(@"^20\d{2}$", ErrorMessage = "Please enter a valid year.")]
        public string GrantYearEnd { get; set; }
        [DataType(DataType.Currency), Display(Name = "Total grant value"), Required]
        [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal TotalGrantValue { get; set; }
        [DataType(DataType.Currency), Display(Name = "Amount for year 1")]
       [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal AmountInYear1 { get; set; }
        [DataType(DataType.Currency), Display(Name = "Amount for year 2")]
        [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal AmountInYear2 { get; set; }
        [DataType(DataType.Currency), Display(Name = "Amount for year 3")]
        [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal AmountInYear3 { get; set; }
        [DataType(DataType.Currency), Display(Name = "Amount for year 4")]
        [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal AmountInYear4 { get; set; }
        [DataType(DataType.Currency), Display(Name = "Amount for year 5")]
        [Column(TypeName = "decimal(18, 0)"), DisplayFormat(DataFormatString = "{0:C0}" )]
        public decimal AmountInYear5 { get; set; }
        [Required, Display(Name = "Staff number")]
        public string StaffNumber { get; set; }
        [Required,Display(Name = "Title")]
        public int? TitleID { get; set; }
        public virtual Title Title { get; set; }
        [Required, Display(Name = "Initials")]
        public string Initials { get; set; }
        [Required, Display(Name = "First name(s)")]
        public string FirstNames { get; set; }
        [Required, Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required, Display(Name = "Gender")]
        public int? GenderID { get; set; }
        public virtual Gender Gender { get; set; }
        [Required, Display(Name = "Race")]
        public int? RaceID { get; set; }
        public virtual Race Race { get; set; }
        [Required, Display(Name = "Email address"), RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string EmailAddress { get; set; }
        [Required, Display(Name = "Faculty")]
        public int? FacultyID { get; set; }
        public virtual Faculty Faculty { get; set; }
        [Required,Display(Name = "Department")]
        public int? DepartmentID { get; set; } 
        public virtual Department Department { get; set; }
       [Required]
        public string Nationality { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
