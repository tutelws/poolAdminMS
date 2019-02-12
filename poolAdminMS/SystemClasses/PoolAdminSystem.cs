using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poolAdminMS.Interfaces;
using poolAdminMS.UserControls;
using System.Drawing;


namespace poolAdminMS.SystemClasses
{

    public class PoolAdminSystem : ICalendarManager, IClientManager, ITrainingGroupsManager
    {

        //CalendarFields
        private List<DayTimeSet> currDayTimeSet;
        //весь список строк для каждого промежутка времени на определенный день
        private List<CalendarTimeRow> currCalendarTimeRows;
        //ClientManagerFields
        private List<TrainingGroup> currTrainingGroups;
        private List<ServiceType> currServiceTypes;
        private List<VisitType> currVisitTypes;
        private List<Client> currClientsList;
        private List<Abonement> currClientAbonements;
        private List<ClientType> currClientTypes;
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

        private void SetCalendarTimeRowLane(ref CalendarTimeRow ctr, int laneIndex, int? laneValue)
        { 
            switch (laneIndex)
            {
                case 1:
                    ctr.Lane1 = laneValue;
                    break;
                case 2:
                    ctr.Lane2 = laneValue;
                    break;
                case 3:
                    ctr.Lane3 = laneValue;
                    break;
                case 4:
                    ctr.Lane4 = laneValue;
                    break;
                case 5:
                    ctr.Lane5 = laneValue;
                    break;
                case 6:
                    ctr.Lane6 = laneValue;
                    break;
            }
        }
        public void SaveCalendarDataGridViewCmbCellChanges(DateTime currDate, DataGridViewComboBoxCell cmbCell)
        {
            int rowInd = cmbCell.RowIndex;
            int dayTimeSetId = DayTimeSetIndexToId(rowInd);
            using (poolDBEntities ent = new poolDBEntities())
            {
                List<CalendarTimeRow> currDateCtrs = ent.CalendarTimeRows.Where(c => System.Data.Entity.DbFunctions.TruncateTime(c.Date) == currDate.Date).ToList();
                CalendarTimeRow ctr = currDateCtrs?.Find(c => c.TimeId == dayTimeSetId);
                if (ctr == null)
                {
                    if (cmbCell.Value == null)
                        return;
                    CalendarTimeRow newCtr = new CalendarTimeRow();
                    newCtr.TimeId = dayTimeSetId;
                    newCtr.Date = currDate;
                    SetCalendarTimeRowLane(ref newCtr, cmbCell.ColumnIndex, GetTrainingGroupIdByName(cmbCell.Value as string));
                    ent.CalendarTimeRows.Add(newCtr);
                    //ent.Entry(newCtr).State = System.Data.Entity.EntityState.Added;
                }
                else
                {
                    SetCalendarTimeRowLane(ref ctr, cmbCell.ColumnIndex, GetTrainingGroupIdByName(cmbCell.Value as string));
                    if (ctr.Lane1 == null &&
                        ctr.Lane2 == null &&
                        ctr.Lane3 == null &&
                        ctr.Lane4 == null &&
                        ctr.Lane5 == null &&
                        ctr.Lane6 == null)
                        ent.CalendarTimeRows.Remove(ctr);
                    //ent.Entry(ctr).State = System.Data.Entity.EntityState.Modified;
                }
                ent.SaveChanges();
            }
        }

        //trash
        public void SaveCalendarTimeRows(DataGridView dgv, DateTime currDate)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                bool isColumnNotEmpty = false;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    isColumnNotEmpty = false;
                    for (int j = 1; j < dgv.ColumnCount; j++)
                        if ((dgv[j, i] as DataGridViewComboBoxCell).Value != null)
                        {
                            isColumnNotEmpty = true;
                            break;
                        }
                    if (isColumnNotEmpty)
                    {
                        CalendarTimeRow ctr = new CalendarTimeRow();
                        List<TrainingGroup> tgs;
                        tgs = GetTrainingGroupByName(dgv[1, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane1 = tgs[0].Id;
                        tgs = GetTrainingGroupByName(dgv[2, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane2 = tgs[0].Id;
                        tgs = GetTrainingGroupByName(dgv[3, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane3 = tgs[0].Id;
                        tgs = GetTrainingGroupByName(dgv[4, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane4 = tgs[0].Id;
                        tgs = GetTrainingGroupByName(dgv[5, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane5 = tgs[0].Id;
                        tgs = GetTrainingGroupByName(dgv[6, i].Value as string);
                        if (tgs.Count != 0)
                            ctr.Lane6 = tgs[0].Id;
                        ctr.TimeId = DayTimeSetIndexToId(i);
                        ctr.Date = currDate;
                        ent.CalendarTimeRows.Add(ctr);
                        ent.SaveChanges();
                    }
                }
            }
            
        }

        #region CalendarManager
        public int DayTimeSetIdToIndex(int id)
        {
            if (currDayTimeSet == null)
                GetNewDayTimeSetList();
            return currDayTimeSet.FindIndex(dts => dts.Id == id);
        }
        public int DayTimeSetIndexToId(int index)
        {
            if (currDayTimeSet == null)
                GetNewDayTimeSetList();
            return currDayTimeSet[index].Id;

        }
        public List<CalendarTimeRow> GetNewCalendarTimeRowsByDate(DateTime currDate)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                currCalendarTimeRows = ent.CalendarTimeRows
                    .Where(c => System.Data.Entity.DbFunctions.TruncateTime(c.Date) == currDate.Date).ToList();

                //currCalendarTimeRows = trans.ToList();
                return currCalendarTimeRows;
            }
        }
        public void SetTimeRowsOnDay(DateTime date)
        {
            using (poolDBEntities ent = new poolDBEntities())
            {

            }
        }
        public string GetComboBoxValueByTrainingGroupId(int? id)
        {
            return currTrainingGroups.Find(t => t.Id == id)?.GroupName;
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
        #endregion
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
        public ClientType GetClientTypeByClient(Client client)
        {
            if (currClientTypes == null)
                GetNewClientTypeList();
            return currClientTypes.Find(c => c.Id == client.TypeId);
        }
        #endregion

        #region getByName(string)
        public int GetClientTypeComboBoxIndexById(int id)
        {
            if (currClientTypes == null)
                GetNewClientTypeList();
            return currClientTypes.FindIndex(c => c.Id == id);
        }
        public int GetClientTypeIdByName(string name)
        {
            if (currClientTypes == null)
                GetNewClientTypeList();
            return currClientTypes.Find(c => c.TypeName == name).Id;
        }
        public int? GetTrainingGroupIdByName(string trainingGroupName)
        {
            int id = 0;
            TrainingGroup tg = currTrainingGroups.Find(t => t.GroupName == trainingGroupName);
            if (tg == null) return null;
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
        public List<ClientType> GetNewClientTypeList()
        {
            using (poolDBEntities ent = new poolDBEntities())
            {
                currClientTypes = ent.ClientTypes.ToList();
                return currClientTypes;
            }
        }
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
            if (name == CalendarDayLarge.EMPTY_CELL_DEFAULT_VALUE)
                return null;
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

        public Image ConvertAbonimentIdToBarcode(int id, int maxBarHeight)
        {
            Zen.Barcode.Code128BarcodeDraw barcodeImage = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            return barcodeImage.Draw(id.ToString(), maxBarHeight);
        }

    }
}
