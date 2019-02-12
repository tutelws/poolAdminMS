using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poolAdminMS.Interfaces;
using poolAdminMS.Forms;

namespace poolAdminMS.UserControls
{
    public partial class ClientsControl : UserControl
    {
        private bool isSaved;
        private bool isAddingState;
        private bool isWatchingState;
        private int currClientId;
        private IClientManager clientManager;
        public ClientsControl(IClientManager clientManager)
        {
            InitializeComponent();
            searchTextBox.ForeColor = Color.Gray;
            searchTextBox.Text = "Данные поиска...";
            this.isSaved = true;
            this.isAddingState = false;
            this.isWatchingState = true;
            this.currClientId = -1;
            this.clientManager = clientManager;
            AbonementFieldsComboBoxDataSources();
            UpdateClientsDataGrid(clientManager.GetNewClientList());
            muteAllState();

        }

        //events
        private void visitCountTextBox_TextChanged(object sender, EventArgs e)
        {
            int vc = 0;
            if (!int.TryParse(visitCountTextBox.Text, out vc))
            {
                visitCountTextBox.Text = "0";
            }
            else
                if (vc < 0) visitCountTextBox.Text = "0";
        }
       
        private void abonementsIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSaved) saveQuation();
            SetCurrAbonement();
        }
        private void saveAbonButton_Click(object sender, EventArgs e)
        {
            if (checkAbonementFields())
                saveAbonementChanges();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            editState();
            isSaved = false;
        }
        private void checkVisitButton_Click(object sender, EventArgs e)
        {
            AcceptDialogForm a = new AcceptDialogForm("Вы уверены, что хотите отметить посещение?");

            if (a.ShowDialog() == DialogResult.OK)
            {
                int vc = 0;
                int.TryParse(visitCountTextBox.Text, out vc);
                if (vc != 0)
                {
                    vc--;
                    visitCountTextBox.Text = vc.ToString();
                    clientManager.CheckVisitWithDate(Convert.ToInt32(abonementsIdComboBox.SelectedItem.ToString()), DateTime.Today);
                    saveAbonementChanges();
                }
                if (visitCountTextBox.Text == "0")
                {
                    AcceptDialogForm b = new AcceptDialogForm("Абонемент закончился.\n Удалить абонемент?");
                    if (b.ShowDialog() == DialogResult.OK)
                    {
                        int aid = 0;
                        int.TryParse(abonementsIdComboBox.SelectedItem.ToString(), out aid);
                        clientManager.DeleteAbonementById(aid);
                        UpdateAbonements(currClientId);
                    }
                }
                
                

            }
        }
        private void addAbonementButton_Click(object sender, EventArgs e)
        {
            if (currClientId == -1)
            {
                MessageBox.Show("Выберите клиента");
                return;
            }

            isSaved = false;
            MessageBox.Show("Запишите всю информацию об абонементе...");
            addingState();
        }
        private void searchTextBox_Enter(object sender, EventArgs e)
        {

            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Text = "";
        }
        private void searchBySurnameButton_Click(object sender, EventArgs e)
        {
            UpdateClientsDataGrid(clientManager.GetClientListBySurname(searchTextBox.Text));
        }
        private void searchByAbonementIdButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(searchTextBox.Text, out id))
            {

                UpdateClientsDataGrid(clientManager.GetClientByAbonementId(id));
                if (!isSaved) saveQuation();
                watchingState();
                UpdateAbonements(Convert.ToInt32(clientsDataGrid.CurrentRow.Cells[0].Value));
            }
            else
                MessageBox.Show("Неверные данные");
        }
        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            UpdateClientsDataGrid(clientManager.GetNewClientList());
            muteAllState();
        }
        private void addClientButton_Click_1(object sender, EventArgs e)
        {
            AddEditClientForm f = new AddEditClientForm(clientManager);
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsDataGrid(clientManager.GetNewClientList());
            }
        }
        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            AcceptDialogForm f = new AcceptDialogForm("Вы уверены, что хотите удалить посетителя?");
            if (f.ShowDialog() == DialogResult.OK)
            {

                int id = Convert.ToInt32(clientsDataGrid.CurrentRow.Cells[0].Value);
                clientManager.DeleteClientById(id);
                UpdateClientsDataGrid(clientManager.GetNewClientList());
                clearAbonement();
            }

        }
        private void editClientButton_Click(object sender, EventArgs e)
        {

            AddEditClientForm f = new AddEditClientForm(clientManager, clientManager.GetClientById(Convert.ToInt32(clientsDataGrid.CurrentRow.Cells[0].Value)));
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsDataGrid(clientManager.GetNewClientList());
            }
        }
        //updates
        private void UpdateClientsDataGrid(List<Client> clients)
        {
            //clientsDataGrid.DataSource = clientManager.GetClientsList();
            clientsDataGrid.Rows.Clear();
            if (clients.Count < 1)
            {
                MessageBox.Show("Посетители не найдены");
                return;
            }
            foreach (Client c in clients)
            {
                clientsDataGrid.Rows.Add(c.Id, c.Surname, c.Name, c.Secondname, c.Phone, ((bool)c.Gender) ? "М" : "Ж");

            }
            clientsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //foreach (DataGridTextBoxColumn c in clientsDataGrid.Columns)

        }
        private void UpdateAbonements(int id)
        {
            Client currC = clientManager.GetClientById(id);
            clientTypeLable.Text = clientManager.GetClientTypeByClient(currC).TypeName;
            fioLable.Text = currC.Surname + " " + currC.Name + " " + currC.Secondname;
            currClientId = currC.Id;
            //abonementsIdComboBox.SelectedIndex = -1;
            AbonementIdComboBoxDataSourceUpdate(id);

            visitTypeСomboBox.SelectedIndex = -1;
            serviceTypeComboBox.SelectedIndex = -1;
            trainingGroupsComboBox.SelectedIndex = -1;


            if (abonementsIdComboBox.Items.Count > 0)
            {
                abonementsIdComboBox.SelectedIndex = 0;
                SetCurrAbonement();
            }
            else
            {
                muteAllState();
                addAbonementButton.Enabled = true;
            }



        }
        private void SetCurrAbonement()
        {
            int id;
            if (abonementsIdComboBox.Items.Count < 1) return;
            if (Int32.TryParse(abonementsIdComboBox.SelectedItem.ToString(), out id))
            {
                Abonement a = clientManager.GetAbonementById(id);
                //if (a.VisitTypeId != null)
                string typeName = clientManager.GetVisitTypeById(a.VisitTypeId).TypeName;
                if (typeName != null)
                    visitTypeСomboBox.SelectedIndex = visitTypeСomboBox.FindString(typeName);

                string sTypeName = clientManager.GetServiceTypeById(a.ServiceTypeId).TypeName;
                if (sTypeName != null)
                    serviceTypeComboBox.SelectedIndex = serviceTypeComboBox.FindString(sTypeName);
                if (a.TrainingGroupId != null)
                {
                    string grName = clientManager.GetTrainingGroupById((int)a.TrainingGroupId).GroupName;
                    trainingGroupsComboBox.SelectedIndex = trainingGroupsComboBox.FindString(grName);
                }
                else
                    trainingGroupsComboBox.SelectedIndex = trainingGroupsComboBox.Items.Count - 1;
                
                visitCountTextBox.Text = a.VisitCount.ToString();
                dateEndPicker.Value = a.DateEnd.Date;
                //dateEndTextBox.Text = a.DateEnd.Date.ToShortDateString();
            }
        }
        private void AbonementIdComboBoxDataSourceUpdate(int id)
        {
            List<Abonement> abons = clientManager.GetNewClientAbonementsList(id);
            abonementsIdComboBox.Items.Clear();
            foreach (Abonement a in abons)
                abonementsIdComboBox.Items.Add(a.Id);
            if (abonementsIdComboBox.Items.Count == 0)
            {
                abonementsIdComboBox.SelectedIndex = -1;
                muteAllState();
                addAbonementButton.Enabled = true;
            }
            else
                abonementsIdComboBox.SelectedIndex = 0;
        }
        private void AbonementFieldsComboBoxDataSources()
        {
            visitTypeСomboBox.Items.Clear();
            serviceTypeComboBox.Items.Clear();
            trainingGroupsComboBox.Items.Clear();
            List<VisitType> vt = clientManager.GetNewVisitTypeList();
            foreach (VisitType v in vt)
                visitTypeСomboBox.Items.Add(v.TypeName);
            List<ServiceType> st = clientManager.GetNewServiceTypeList();
            foreach (ServiceType s in st)
                serviceTypeComboBox.Items.Add(s.TypeName);
            List<TrainingGroup> tg = clientManager.GetNewTrainingGroupList();
            foreach (TrainingGroup t in tg)
                trainingGroupsComboBox.Items.Add(t.GroupName);
            trainingGroupsComboBox.Items.Add("Не состоит в тренеровочной группе");
        }
        //saves
        private bool checkAbonementFields()
        {
            if (visitTypeСomboBox.SelectedIndex < 0 ||
                serviceTypeComboBox.SelectedIndex < 0 ||
                trainingGroupsComboBox.SelectedIndex < 0
                )
            {
                MessageBox.Show("Пожалуйста заполните все поля");
                return false;
            }
            return true;
        }
        private void saveAbonementChanges()
        {
            if (currClientId == -1) return;
            Abonement abon = new Abonement();
            if (!isAddingState)
                abon.Id = Convert.ToInt32(abonementsIdComboBox.SelectedItem.ToString());
            abon.VisitTypeId = clientManager.GetVisitTypeIdByName(visitTypeСomboBox.SelectedItem.ToString());
            abon.ServiceTypeId = clientManager.GetServiceTypeIdByName(serviceTypeComboBox.SelectedItem.ToString());
            int? tgid = clientManager.GetTrainingGroupIdByName(trainingGroupsComboBox.SelectedItem.ToString());
            if (tgid != null)
                abon.TrainingGroupId = tgid;
            DateTime dt = dateEndPicker.Value;
            abon.DateEnd = dt;
            //if (DateTime.TryParse(dateEndTextBox.Text, out dt))
            //    abon.DateEnd = dt;
            int vc = 0;
            if (int.TryParse(visitCountTextBox.Text, out vc))
                abon.VisitCount = vc;
            abon.ClientId = currClientId;
            if (isAddingState)
                clientManager.AddAbonement(abon);
            else
                clientManager.EditAbonement(abon);
            MessageBox.Show("Сохранено!");
            isSaved = true;
            if (isAddingState)
                AbonementIdComboBoxDataSourceUpdate(currClientId);
            watchingState();
            
            
                
        }
        private void saveQuation()
        {
            if (isSaved) return;
            AcceptDialogForm f = new AcceptDialogForm("Сохранить изменения?");
            if (f.ShowDialog() == DialogResult.OK)
                saveAbonementChanges();
            else
                isSaved = true;

        }
        //states
        private void muteAllState()
        {
            isWatchingState = false;
            isAddingState = false;
            serviceTypeComboBox.Enabled = false;
            visitTypeСomboBox.Enabled = false;
            abonementsIdComboBox.Enabled = false;
            trainingGroupsComboBox.Enabled = false;
            dateEndPicker.Enabled = false;
            checkVisitButton.Enabled = false;
            addAbonementButton.Enabled = false;
            visitCountTextBox.Enabled = false;
            editButton.Enabled = false;
            saveAbonButton.Enabled = false;
            deleteAbonButton.Enabled = false;
        }
        private void addingState()
        {
            isAddingState = true;
            isWatchingState = false;

            serviceTypeComboBox.Enabled = true;
            visitTypeСomboBox.Enabled = true;
            abonementsIdComboBox.Enabled = false;
            trainingGroupsComboBox.Enabled = true;
            saveAbonButton.Enabled = true;
            dateEndPicker.Enabled = true;
            checkVisitButton.Enabled = false;
            addAbonementButton.Enabled = false;
            visitCountTextBox.Enabled = true;
            editButton.Enabled = false;
            deleteAbonButton.Enabled = false;
        }
        private void watchingState()
        {
            isWatchingState = true;
            isAddingState = false;

            serviceTypeComboBox.Enabled = false;
            visitTypeСomboBox.Enabled = false;
            abonementsIdComboBox.Enabled = true;
            trainingGroupsComboBox.Enabled = false;

            saveAbonButton.Enabled = true;
            dateEndPicker.Enabled = false;
            checkVisitButton.Enabled = true;
            addAbonementButton.Enabled = true;
            visitCountTextBox.Enabled = false;
            editButton.Enabled = true;
            saveAbonButton.Enabled = true;
            deleteAbonButton.Enabled = true;
        }
        private void editState()
        {
            isWatchingState = true;
            isAddingState = false;

            serviceTypeComboBox.Enabled = true;
            visitTypeСomboBox.Enabled = true;
            abonementsIdComboBox.Enabled = true;
            trainingGroupsComboBox.Enabled = true;

            dateEndPicker.Enabled = true;
            checkVisitButton.Enabled = false;
            addAbonementButton.Enabled = false;
            visitCountTextBox.Enabled = true;
            editButton.Enabled = false;
            saveAbonButton.Enabled = true;
            deleteAbonButton.Enabled = false;
        }
        //clears
        private void clearAbonement()
        {
            abonementsIdComboBox.Items.Clear();
            trainingGroupsComboBox.SelectedIndex = -1;
            visitTypeСomboBox.SelectedIndex = -1;
            serviceTypeComboBox.SelectedIndex = -1;
            visitCountTextBox.Text = "";
            fioLable.Text = "ФИО";
            muteAllState();
            currClientId = -1;
        }

        private void deleteAbonButton_Click(object sender, EventArgs e)
        {
            AcceptDialogForm f = new AcceptDialogForm("Подтвердите удаление абонемента...");
            int aid = 0;
            if (f.ShowDialog() == DialogResult.OK && int.TryParse(abonementsIdComboBox.SelectedItem.ToString(), out aid))
            {
                clientManager.DeleteAbonementById(aid);
                UpdateAbonements(currClientId);
            }
           
        }


        private void clientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientsDataGrid.SelectedRows.Count <= 0) return;
            if (!isSaved) saveQuation();
            watchingState();
            UpdateAbonements(Convert.ToInt32(clientsDataGrid.CurrentRow.Cells[0].Value));
        }
    }
}
