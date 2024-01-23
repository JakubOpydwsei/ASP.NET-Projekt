using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_app.Models
{
    public class Car
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać model!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długi model, max 50 znaków!")]
        [Display(Name = "Model:")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Musisz podać producenta!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długi producent, max 50 znaków!")]
        [Display(Name = "Producent:")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Musisz podać pojemność silnika!")]
        [Display(Name = "Pojemność silnika:")]
        public double EngineCapacity { get; set; }

        [Required(ErrorMessage = "Musisz podać moc silnika!")]
        [Display(Name = "Moc silnika:")]
        public int Power { get; set; }

        [Required(ErrorMessage = "Musisz podać numer rejestracyjny!")]
        [Display(Name = "Nr rejestracyjny:")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Musisz podać właściciela!")]
        [Display(Name = "Właściciel:")]
        public string Owner { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
