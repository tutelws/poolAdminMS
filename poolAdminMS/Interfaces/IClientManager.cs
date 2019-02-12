using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poolAdminMS.SystemClasses;

namespace poolAdminMS.Interfaces
{
    public interface IClientManager
    {
        void DeleteClientById(int id);
        void AddClient(Client client);
        void EditClient(Client client);

        void EditAbonement(Abonement abonement);
        void AddAbonement(Abonement abonement);
        void DeleteAbonementById(int id);

        void CheckVisitWithDate(int abonementId, DateTime date);

        List<Client> GetClientListBySurname(string surname);
        List<Client> GetClientByAbonementId(int id);

        List<Client> GetNewClientList();
        List<Abonement> GetNewClientAbonementsList(int gridPos);
        List<TrainingGroup> GetNewTrainingGroupList();
        List<ServiceType> GetNewServiceTypeList();
        List<VisitType> GetNewVisitTypeList();
        List<ClientType> GetNewClientTypeList();

        TrainingGroup GetTrainingGroupById(int id);
        int? GetTrainingGroupIdByName(string trainingGroupName);

        ServiceType GetServiceTypeById(int id);
        int GetServiceTypeIdByName(string serviceTypeName);

        VisitType GetVisitTypeById(int id);
        int GetVisitTypeIdByName(string visitTypeName);

        Client GetClientById(int id);
        Abonement GetAbonementById(int id);

        ClientType GetClientTypeByClient(Client client);
        int GetClientTypeIdByName(string name);
        int GetClientTypeComboBoxIndexById(int id);
    }
}
