using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	List<eleve> GetAll();

	[OperationContract]
	int Insert(string cne, string prenom, string nom, string email, string filiere, string tel);

	[OperationContract]
	int DeleteEleve(string cne);

	[OperationContract]
	int UpdateEleve(string cne, string prenom, string nom, string email, string filiere, string tel);

	[OperationContract]
	eleve GetOne(string cne);
}

