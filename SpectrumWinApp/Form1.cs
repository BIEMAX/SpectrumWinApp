using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrumWinApp
{
    public partial class Form1 : Form
    {

        #region Globals

        private List<PeakAreas> mLstPeakAreas = new List<PeakAreas>();
        private DataTable mDados = new DataTable();

        #endregion

        public Form1()
        {
            InitializeComponent();
            LoadAppInfo();
        }


        #region Events

        private void txtWavenumber_TextChanged(object sender, EventArgs e)
        {
            txtWavenumber.Text = CustomStrings.DeixaSomenteNumeros(this.Text);
        }

        private void txtTransmitance_TextChanged(object sender, EventArgs e)
        {
            txtTransmitance.Text = CustomStrings.DeixaSomenteNumeros(this.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                AddPeakArea();
            }
            catch (Exception ex) { }
        }

        #endregion

        #region Methods

        protected private void LoadAppInfo()
        {
            this.Text = $"Spectrum - V {Application.ProductVersion}";
            if (DateTime.Now >= new DateTime(2022, 03, 31))
            {
                foreach(Control c in this.Controls) c.Enabled = false;
                MessageBox.Show("Licença válida até dia 31/03/2022", "Licença expirada");
                this.Dispose();
                this.Close();
            }
        }

        protected private void AddPeakArea()
        {
            Double waveNumber = Convert.ToDouble(txtWavenumber.Text);
            Double transmitance = Convert.ToDouble(txtTransmitance.Text);
            Double filterValue = mLstPeakAreas.Count() <= 0 ? 0.0 : mLstPeakAreas[mLstPeakAreas.Count() - 1].Transmitance - transmitance;

            mLstPeakAreas.Add(new PeakAreas()
            {
                WaveNumber = waveNumber,
                Transmitance = transmitance,
                Filter = filterValue,
            });
        }

        #endregion
    }
}