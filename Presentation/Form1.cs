using Core;

namespace Presentation
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        DataBaseController _controller = new DataBaseController();

        public Form1()
        {
            try
            {
                InitializeComponent();
                DrawAllData();
                UpdateSpecId();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.CreateSpecialization(NameSpec.Text);
                DrawAllData();
                UpdateSpecId();
                UpdateDocId();
                ClearAllLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = SpecializationsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (SpecializationsGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(SpecializationsGridView.SelectedRows[i].Cells[0].Value.ToString());
                    _controller.DeleteSpecialization(Id);
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
                UpdateSpecId();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSpecButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = SpecializationsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (SpecializationsGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(SpecializationsGridView.SelectedRows[i].Cells[0].Value.ToString());
                    _controller.UpdateSpecializations(Id, NameSpec.Text);
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
                UpdateSpecId();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SpecId.Text, out int specId))
                    throw new ArgumentException("Incorrectly transmitted data");
                _controller.CreateDoctor(specId, DocName.Text);
                DrawAllData();
                ClearAllLabels();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = DoctorsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (DoctorsGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(DoctorsGridView.SelectedRows[i].Cells[0].Value.ToString());
                    _controller.DeleteDoctor(Id);
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = DoctorsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                string docName = DocName.Text;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (DoctorsGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(DoctorsGridView.SelectedRows[i].Cells[0].Value.ToString());
                    if (!int.TryParse(SpecId.Text, out int specId))
                        specId = int.Parse(DoctorsGridView.SelectedRows[i].Cells[1].Value.ToString());
                    if (docName == String.Empty)
                        docName = DoctorsGridView.SelectedRows[i].Cells[2].Value.ToString();
                    _controller.UpdateDoctors(Id, specId, docName);
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
                UpdateDocId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateCertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(DocId.Text, out int docId))
                    throw new ArgumentException("Incorrectly transmitted data");
                _controller.CreateCertificate(docId, Descripption.Text, dateTimePicker.Value.ToUniversalTime());
                DrawAllData();
                ClearAllLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = CertificatesGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (CertificatesGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(CertificatesGridView.SelectedRows[i].Cells[0].Value.ToString());
                    _controller.DeleteCertificate(Id);
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowCount = CertificatesGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                string description = Descripption.Text;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    if (CertificatesGridView.SelectedRows[i].Cells[0].Value == null)
                        throw new ArgumentException("A non-existing cell is selected");
                    int Id = int.Parse(CertificatesGridView.SelectedRows[i].Cells[0].Value.ToString());
                    if (!int.TryParse(DocId.Text, out int docId))
                        docId = int.Parse(CertificatesGridView.SelectedRows[i].Cells[1].Value.ToString());
                    if (description == String.Empty)
                        description = CertificatesGridView.SelectedRows[i].Cells[2].Value.ToString();
                    _controller.UpdateCertificates(Id, docId, description, dateTimePicker.Value.ToUniversalTime());
                }
                DrawAllData();
                HideButtons();
                ClearAllLabels();
                SpecTypeLabel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawSpecializations()
        {
            SpecializationsGridView.Rows.Clear();
            var specializations = _controller.GetSpecializationsList();
            foreach(var specialization in specializations)
                SpecializationsGridView.Rows.Add(specialization.Id, specialization.Name);
        }

        private void DrawDoctors()
        {
            DoctorsGridView.Rows.Clear();
            var doctors = _controller.GetDoctorsList();
            foreach (var doctor in doctors)
                DoctorsGridView.Rows.Add(doctor.Id, doctor.SpecializationsId, doctor.Name);
        }

        private void DrawCertificates()
        {
            CertificatesGridView.Rows.Clear();
            var certificates = _controller.GetCertificatesList();
            foreach (var certificate in certificates)
                CertificatesGridView.Rows.Add(certificate.Id, certificate.DoctorsId, certificate.Description, certificate.Date);
        }

        private void DrawAllData()
        {
            DrawSpecializations();
            DrawDoctors();
            DrawCertificates();
        }

        private void ClearAllLabels()
        {
            DocWithSpecLabel.Text = "";
            SpecTypeLabel.Text = "";
            lastCertLabel.Text = "";
        }

        private void HideButtons()
        {
            DeleteSpecButton.Visible = false;
            UpdateSpecButton.Visible = false;
            DeleteDocButton.Visible = false;
            UpdateDocButton.Visible = false;
            DeleteCertButton.Visible = false;
            UpdateCertButton.Visible = false;
        }

        private void UpdateSpecId()
        {
            SpecId.Items.Clear();
            var specializations = _controller.GetSpecializationsList().ToList();
            for (int i = 0; i < specializations.Count(); i++)
                SpecId.Items.Add(specializations[i].Id);
        }

        private void UpdateDocId()
        {
            DocId.Items.Clear();
            var doctors = _controller.GetDoctorsList().ToList();
            for (int i = 0; i < doctors.Count(); i++)
                DocId.Items.Add(doctors[i].Id);
        }

        private void CellMouseSpecializationsClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DeleteSpecButton.Visible = true;
                UpdateSpecButton.Visible = true;
                int selectedRowCount = SpecializationsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 1)
                    throw new ArgumentException("Choose a specific specialization");
                if (SpecializationsGridView.SelectedRows[0].Cells[0].Value != null)
                    DocWithSpecLabel.Text = _controller.NumberDoctorsWithSuchSpec(int.Parse(
                        SpecializationsGridView.SelectedRows[0].Cells[0].Value.ToString())).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CellMouseDoctorsClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DeleteDocButton.Visible = true;
                UpdateDocButton.Visible = true;
                int selectedRowCount = CertificatesGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 1)
                    throw new ArgumentException("Choose a specific doctor");
                if (DoctorsGridView.SelectedRows[0].Cells[0].Value != null)
                    lastCertLabel.Text = _controller.GetLastCertificate(int.Parse(
                        DoctorsGridView.SelectedRows[0].Cells[0].Value.ToString())).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CellMouseCertificatesClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DeleteCertButton.Visible = true;
                UpdateCertButton.Visible = true;
                int selectedRowCount = CertificatesGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 1)
                    throw new ArgumentException("Choose a specific certificate");
                if (CertificatesGridView.SelectedRows[0].Cells[0].Value != null)
                    SpecTypeLabel.Text = _controller.GetSpecializationTypeForCertificate(int.Parse(
                        CertificatesGridView.SelectedRows[0].Cells[1].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}