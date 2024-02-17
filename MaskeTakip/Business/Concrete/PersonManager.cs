﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

//çıplak class kalmasın
public class PersonManager: IApplicantService
{
    //encapsulation
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {

        return null;
    }

    public bool checkPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }
}
