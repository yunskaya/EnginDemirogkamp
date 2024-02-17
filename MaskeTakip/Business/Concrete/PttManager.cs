using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService; //field

        public PttManager(IApplicantService applicantService) //constructor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            /*bir iş sınıfı başka bir iş sınıfını kullanırken new'liyorsa ileriye 
                dönük değişiklik talebi geldiğinde değişikliğe direç gösterir */
      
            if (_applicantService.checkPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }
    }
}
