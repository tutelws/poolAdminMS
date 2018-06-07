using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poolAdminMS.Interfaces;
using System.Drawing;

namespace poolAdminMS.SystemClasses
{
    
    public class PoolAdminSystem : ICalendarManager, IClientManager, ITrainingGroupsManager
    {
        //CalendarFields
        private List<DayTimeSet> currDayTimeSet;
        //ClientManagerFields
        private List<TrainingGroup> currTrainingGroups;
        private List<ServiceType> currServiceTypes;
        private List<VisitType> currVisitTypes;
        private List<Client> currClientsList;
        private List<Abonement> currClientAbonements;

        //TrainingGroupManagerFields
        private List<Employee> currEmployeeList;
        private List<EmployeesPosition> currEmployeePositions;
        //private List<Employee> currCoachList;
        

        public List<ServiceType> CurrServiceTypes
        {
            get
            {
                return currServiceTypes;
            }

            //set
            //{
            //    currServiceTypes = value;
            //}
        }

        public List<VisitType> CurrVisitTypes
        {
            get
            {
                return currVisitTypes;
            }

            //set
            //{
            //    currVisitTypes = value;
            //}
        }

        


        public PoolAdminSystem()
        {
           
        }



        public void SetTimeRowsOnDay(DateTime date)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {

            }
        }
        public TrainingGroup GetTrainingGroupByComboBoxIndex(int ind)
        {
            return currTrainingGroups[ind];
        }
        public Color GetTrainingGroupColorByComboBoxIndex(int ind)
        {
            Color c = Color.White;
            TrainingGroup tg = GetTrainingGroupByComboBoxIndex(ind);
            if (tg.Color != null && tg.Color.Length == 4)
            {
                c = Color.FromArgb(tg.Color[0], tg.Color[1], tg.Color[2], tg.Color[3]);
            }
            return c;
        }
        public List<DayTimeSet> GetNewDayTimeSetList()
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                currDayTimeSet = ent.DayTimeSets.ToList();
            }
            return currDayTimeSet;
        }
        public List<TrainingGroup> GetNewTrainingGroupList()
        {
            currTrainingGroups = new List<TrainingGroup>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                var trans = from T in ent.TrainingGroups
                            select T;
                currTrainingGroups = trans.ToList();
            }
            return currTrainingGroups;
        }

        #region ClientManager

        #region getById
        public Client GetClientById(int id)
        {
            return currClientsList.Find(c => c.Id == id);
        }
        public Abonement GetAbonementById(int id)
        {
            return currClientAbonements.Find(a => a.Id == id);
        }
        public VisitType GetVisitTypeById(int id)
        {
            return currVisitTypes.Find(v => v.Id == id);
        }
        public ServiceType GetServiceTypeById(int id)
        {
            return currServiceTypes.Find(s => s.Id == id);
        }
        public TrainingGroup GetTrainingGroupById(int id)
        {
            return currTrainingGroups.Find(t => t.Id == id);
        }
        #endregion

        #region getByName(string)
        public int GetTrainingGroupIdByName(string trainingGroupName)
        {
            int id = 0;
            TrainingGroup tg = currTrainingGroups.Find(t => t.GroupName == trainingGroupName);
            if (tg == null) return -1;
            id = currTrainingGroups.Find(t => t.GroupName == trainingGroupName).Id;
            return id;
        }

        public int GetServiceTypeIdByName(string serviceTypeName)
        {
            int id = 0;
            id = currServiceTypes.Find(s => s.TypeName == serviceTypeName).Id;
            return id;
        }

        public int GetVisitTypeIdByName(string visitTypeName)
        {
            int id = 0;
            id = currVisitTypes.Find(v => v.TypeName == visitTypeName).Id;
            return id;
        }
        #endregion

        #region getNewList
        public List<Client> GetClientListBySurname(string surname)
        {
            return currClientsList.FindAll(c => string.Compare(c.Surname, surname, true) == 0);
        }
        public List<Client> GetClientByAbonementId(int id)
        {
            List<Client> c = new List<Client>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                Abonement abon = ent
                    .Abonements.Where(a => a.Id == id)
                    .FirstOrDefault();
                c.Add(abon.Client);
            }
            return c;
        }
        public List<VisitType> GetNewVisitTypeList()
        {
            currVisitTypes = new List<VisitType>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                var trans = from V in ent.VisitTypes
                            select V;
                currVisitTypes = trans.ToList();
            }
            return currVisitTypes;
        }
        public List<ServiceType> GetNewServiceTypeList()
        {
            currServiceTypes = new List<ServiceType>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                var trans = from S in ent.ServiceTypes
                            select S;
                currServiceTypes = trans.ToList();
            }
            return currServiceTypes;

        }
        public List<Abonement> GetNewClientAbonementsList(int id)
        {
            int ClientId = GetClientById(id).Id;
            using (poolDBEntities ent = new poolDBEntities())
            {
                var trans = from A in ent.Abonements
                            where A.ClientId == ClientId
                            select A;
                currClientAbonements = trans.ToList();
            }
            return currClientAbonements;
        }

        public List<Client> GetNewClientList()
        {
            currClientsList = new List<Client>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                var trans = from C in ent.Clients
                            select C;
                currClientsList = trans.ToList();
            }
            return currClientsList;
        }
        
        
        #endregion
        public void CheckVisitWithDate(int abonementId, DateTime date)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                VisitDate vd = new VisitDate();
                vd.AbonementId = abonementId;
                vd.Date = date.Date;
                vd.ClientId = GetClientByAbonementId(abonementId)[0].Id;
                ent.VisitDates.Add(vd);
                ent.SaveChanges();
            }
        }
        #region add/edit/delete

        public void DeleteAbonementById(int id)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Abonement abonEnt = ent.Abonements
                    .Where(a => a.Id == id)
                    .FirstOrDefault();
                ent.Abonements.Remove(abonEnt);
                ent.SaveChanges();
            }
        }
        public void EditAbonement(Abonement abonement)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Abonement abonEnt = ent.Abonements
                    .Where(a => a.Id == abonement.Id)
                    .FirstOrDefault();
                //abonEnt = abonement;
                abonEnt.VisitTypeId = abonement.VisitTypeId;
                abonEnt.ServiceTypeId = abonement.ServiceTypeId;
                abonEnt.TrainingGroupId = abonement.TrainingGroupId;
                abonEnt.VisitCount = abonement.VisitCount;
                abonEnt.ClientId = abonement.ClientId;
                abonEnt.DateEnd = abonement.DateEnd;

                ent.SaveChanges();
            }
        }
        public void AddAbonement(Abonement abonement)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                ent.Abonements.Add(abonement);
                ent.SaveChanges();
            }
        }

        public void DeleteClientById(int id)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Client cl = ent.Clients
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
                ent.Clients.Remove(cl);
                ent.SaveChanges();
            }
        }
        public void AddClient(Client client)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                ent.Clients.Add(client);
                ent.SaveChanges();
            }
        }
        public void EditClient(Client client)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Client clientEnt = ent.Clients
                    .Where(c => c.Id == client.Id)
                    .FirstOrDefault();
                //abonEnt = abonement;
                clientEnt.Name = client.Name;
                clientEnt.Secondname = client.Secondname;
                clientEnt.Surname = client.Surname;
                clientEnt.Phone = client.Phone;
                clientEnt.Gender = client.Gender;

                ent.SaveChanges();
            }
        }

        #endregion
        #endregion

        #region TrainingGroupManager
        public List<EmployeesPosition> GetNewEmployeePositionList()
        {
            currEmployeePositions = new List<EmployeesPosition>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                currEmployeePositions = ent.EmployeesPositions.ToList();
            }
            return currEmployeePositions;
        }
       
        public List<Employee> GetNewEmployeeList()
        {
            GetNewEmployeePositionList();
            currEmployeeList = new List<Employee>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                currEmployeeList = ent.Employees.ToList();
            }
            return currEmployeeList;
        }
        public List<Employee> GetNewEmployeeListByPositionId(params int[] ids)
        {
            List<Employee> empList = new List<Employee>();
            
            using (poolDBEntities ent = new poolDBEntities())
            {
                int currPosId = 1;
                for (int i = 0; i < ids.Length; i++)
                {
                    currPosId = ids[i];
                    List<Employee> emps = ent.Employees.Where(e => e.PositionId == currPosId).ToList();
                    empList.AddRange(emps);
                }
                
            }
            return empList;
        }
        public List<Employee> GetEmployeesBySurname(string surname)
        {
            return currEmployeeList.FindAll(e => string.Compare(e.Surname, surname, true) == 0);
        }
        public List<TrainingGroup> GetTrainingGroupByName(string name)
        {
            return currTrainingGroups.FindAll(t => string.Compare(t.GroupName, name, true) == 0);
        }
        public string GetPositionNameById(int id)
        {
            return currEmployeePositions.Find(p => p.Id == id).PositionName;
        }
        public Employee GetEmpById(int id)
        {
            return currEmployeeList.Find(e => e.Id == id);
        }
        public List<TrainingGroup> GetCurrTrainingGroupsByEmployeeId(int id)
        {
            throw new NotImplementedException();
        }
        public EmployeesPosition GetEmpPosByName(string name)
        {
            return currEmployeePositions.Find(ep => ep.PositionName == name);
        }
       
        public List<Client> GetClientsByGroupId(int id)
        {
            List<Client> curr = new List<Client>();
            using (poolDBEntities ent = new poolDBEntities())
            {
                curr = ent.Clients.Where(c => (
                c.Abonements.Where(a => 
                a.TrainingGroupId == id)
                .ToList().Count > 0))
                .ToList();
            }
            return curr;
        }
        public void DeleteTrainingGroupById(int id)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                TrainingGroup tg = ent.TrainingGroups.Where(t => t.Id == id).FirstOrDefault();
                ent.TrainingGroups.Remove(tg);
                ent.SaveChanges();
            }
        }

        public void EditTrainingGroup(TrainingGroup tg)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                TrainingGroup dbtg = ent.TrainingGroups.Where(t => t.Id == tg.Id).FirstOrDefault();
                dbtg.GroupName = tg.GroupName;
                dbtg.CoachId = tg.CoachId;
                dbtg.Color = tg.Color;
                ent.SaveChanges();
            }
        }

        public void AddTrainingGroup(TrainingGroup tg)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                ent.TrainingGroups.Add(tg);
                ent.SaveChanges();
            }
        }

        public void DeleteEmployeeById(int id)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Employee emp = ent.Employees.Where(e => e.Id == id).FirstOrDefault();
                ent.Employees.Remove(emp);
                ent.SaveChanges();
            }
        }

        public void EditEmployee(Employee emp)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                Employee dbEmp = ent.Employees.Where(e => e.Id == emp.Id).FirstOrDefault();
                dbEmp.Name = emp.Name;
                dbEmp.Phone = emp.Phone;
                dbEmp.PositionId = emp.PositionId;
                dbEmp.Secondname = emp.Secondname;
                dbEmp.Surname = emp.Surname;
                ent.SaveChanges();
            }
        }

        public void AddEmployee(Employee emp)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                ent.Employees.Add(emp);
                ent.SaveChanges();
            }
        }

        
        #endregion
    }
}
