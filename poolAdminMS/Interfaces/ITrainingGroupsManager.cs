using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolAdminMS.Interfaces
{
    public interface ITrainingGroupsManager
    {

        void DeleteTrainingGroupById(int id);
        void EditTrainingGroup(TrainingGroup tg);
        void AddTrainingGroup(TrainingGroup tg);

        void DeleteEmployeeById(int id);
        void EditEmployee(Employee emp);
        void AddEmployee(Employee emp);

        List<TrainingGroup> GetNewTrainingGroupList();
        List<Employee> GetNewEmployeeList();
        List<TrainingGroup> GetCurrTrainingGroupsByEmployeeId(int id);
        List<EmployeesPosition> GetNewEmployeePositionList();
        List<Employee> GetNewEmployeeListByPositionId(params int[] ids);

        List<Employee> GetEmployeesBySurname(string surname);
        List<TrainingGroup> GetTrainingGroupByName(string name);
        List<Client> GetClientsByGroupId(int id);

        EmployeesPosition GetEmpPosByName(string name);
        Employee GetEmpById(int id);
        TrainingGroup GetTrainingGroupById(int id);
        string GetPositionNameById(int id);

    }
}
