using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    gestioneleveEntities1 gest = new gestioneleveEntities1();

    public List<eleve> GetAll()
    {
        List<eleve> eleves = new List<eleve>();

        var x = from n in gest.eleves select n;
        foreach (var item in x)
        {
            eleve e = new eleve();
            e.cne = item.cne;
            e.prenom = item.prenom;
            e.nom = item.nom;
            e.email = item.email;
            e.filiere = item.filiere;
            e.tel = item.tel;

            eleves.Add(e);
        }
        return eleves;
    }

    public eleve GetOne(string cne)
    {
        var list = from k in gest.eleves where k.cne == cne select k;
        eleve e = new eleve();
        foreach (var item in list)
        {
            e.cne = item.cne;
            e.prenom = item.prenom;
            e.nom = item.nom;
            e.email = item.email;
            e.filiere = item.filiere;
            e.tel = item.tel;
        }
        return e;
    }

    public int Insert(string cne, string prenom, string nom, string email, string filiere, string tel)
    {
        eleve e = new eleve();
        e.cne = cne;
        e.prenom = prenom;
        e.nom = nom;
        e.email = email;
        e.filiere = filiere;
        e.tel = tel;
        gest.eleves.Add(e);

        int res = gest.SaveChanges();
        return res;
    }

    public int UpdateEleve(string cne, string prenom, string nom, string email, string filiere, string tel)
    {
        eleve e = new eleve();
        e.cne = cne;
        e.prenom = prenom;
        e.nom = nom;
        e.email = email;
        e.filiere = filiere;
        e.tel = tel;
        gest.Entry(e).State = System.Data.Entity.EntityState.Modified;
        int res = gest.SaveChanges();
        return res;
    }

    public int DeleteEleve(string cne)
    {
        eleve e = new eleve();
        e.cne = cne;
        gest.Entry(e).State = System.Data.Entity.EntityState.Deleted;
        int res = gest.SaveChanges();
        return res;
    }
}
