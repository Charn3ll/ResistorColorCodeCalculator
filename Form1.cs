namespace ResistorColorCodeCalculator
{
    // Kalkulator kodów paskowych rezystorów oparty na Windows Forms.
    // Umożliwia wybór liczby pasków (4, 5 lub 6) i oblicza rezystancję na podstawie kolorów.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bandNumbersComboBox.SelectedIndex = 2; // "Sześć"
            band1ComboBox.SelectedIndex = 0; // "Brak"
            band2ComboBox.SelectedIndex = 0; // "Brak"
            band3ComboBox.SelectedIndex = 0; // "Brak"
            temperatureComboBox.SelectedIndex = 0; // "Brak"
            toleranceComboBox.SelectedIndex = 0; // "Brak"
            multiplierComboBox.SelectedIndex = 0; // "1 - czarny"
            resistanceResultLabel.Text = "Niekompletne dane!";

            bandNumbersComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            band1ComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            band2ComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            band3ComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            multiplierComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            toleranceComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };
            temperatureComboBox.SelectedIndexChanged += (s, e) => { CalculateResistance(); UpdateResistorImage(); };

            this.Load += Form1_Load;

            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false; 
            this.MinimumSize = this.Size; 
            this.MaximumSize = this.Size; 
        }

        private void bandNumbersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = bandNumbersComboBox.SelectedIndex;

            switch (selected)
            {
                case 0: // "Cztery" paski
                    band3ComboBox.Enabled = false; // Trzeci pasek niewidoczny
                    temperatureComboBox.Enabled = false; // Współczynnik temperaturowy niewidoczny
                    break;

                case 1: // "Pięć" pasków
                    band3ComboBox.Enabled = true; // Trzeci pasek widoczny
                    temperatureComboBox.Enabled = false; // Współczynnik temperaturowy niewidoczny
                    break;

                case 2: // "Sześć" pasków
                    band3ComboBox.Enabled = true; // Trzeci pasek widoczny
                    temperatureComboBox.Enabled = true; // Współczynnik temperaturowy widoczny
                    break;

                default: // wrazie braku wyboru
                    MessageBox.Show("Nieprawidłowy wybór liczby pasków.");
                    break;
            }

            CalculateResistance();
        }

        private void CalculateResistance()
        {
            // Pobierz liczbę pasków (0 = 4 paski, 1 = 5 pasków, 2 = 6 pasków)
            int bandCount = bandNumbersComboBox.SelectedIndex + 4;

            // Sprawdź, czy wszystkie wymagane ComboBoxy mają wybrane opcje
            bool isComplete = true;

            // Sprawdzenie podstawowych ComboBoxów (zawsze wymagane)
            if (band1ComboBox.SelectedItem == null || band1ComboBox.SelectedItem.ToString().StartsWith("Brak") ||
                band2ComboBox.SelectedItem == null || band2ComboBox.SelectedItem.ToString().StartsWith("Brak"))
            {
                isComplete = false;
            }

            // Sprawdzenie trzeciego paska dla 5 lub 6 pasków
            if (bandCount >= 5 && (band3ComboBox.SelectedItem == null || band3ComboBox.SelectedItem.ToString().StartsWith("Brak")))
            {
                isComplete = false;
            }

            if (!isComplete)
            {
                resistanceResultLabel.Text = "Niekompletne dane!";
                return;
            }

            int firstDigit = GetDigitFromComboBox(band1ComboBox);
            int secondDigit = GetDigitFromComboBox(band2ComboBox);
            int thirdDigit = bandCount >= 5 ? GetDigitFromComboBox(band3ComboBox) : 0;
            double multiplier = GetMultiplierFromComboBox(multiplierComboBox);
            string tolerance = GetToleranceFromComboBox(toleranceComboBox);

            double resistance;
            if (bandCount == 4)
            {
                resistance = (firstDigit * 10 + secondDigit) * multiplier;
            }
            else // 5 lub 6 pasków
            {
                resistance = (firstDigit * 100 + secondDigit * 10 + thirdDigit) * multiplier;
            }

            resistanceResultLabel.Text = $"{resistance} Ω ± {tolerance}";
        }

        // Pomocnicza metoda do pobierania cyfr z ComboBoxów
        private int GetDigitFromComboBox(ComboBox comboBox)
        {
            string selectedItemText = comboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItemText) || selectedItemText.StartsWith("Brak"))
                return 0;
            return int.Parse(selectedItemText.Split(' ')[0]);
        }

        // Pomocnicza metoda do pobierania mnożnika
        private double GetMultiplierFromComboBox(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem?.ToString();
            string multiplierText = selected.Split(' ')[0];
            double multiplier;
            if (multiplierText.Contains("K"))
            {
                multiplier = double.Parse(multiplierText.Replace("K", "")) * 1000;
            }
            else if (multiplierText.Contains("M"))
            {
                multiplier = double.Parse(multiplierText.Replace("M", "")) * 1000000;
            }
            else
            {
                multiplier = double.Parse(multiplierText);
            }
            return multiplier;
        }

        // Pomocnicza metoda do pobierania tolerancji
        private string GetToleranceFromComboBox(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected) || selected.StartsWith("Brak"))
                return "0%";
            return selected.Split(' ')[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = resistorImagePictureBox.Width;
            int height = resistorImagePictureBox.Height;

            Bitmap resistorBitmap = new Bitmap("Images/resistorBG.png");
            resistorBitmap = new Bitmap(resistorBitmap, new Size(width, height)); // Przeskaluj tło

            using (Graphics graphics = Graphics.FromImage(resistorBitmap))
            {
                // Nałóż domyślny pasek mnożnika (czarny)
                string multiplier = multiplierComboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(multiplier))
                {
                    string color = GetColorFromComboBox(multiplier);
                    string filePath = $"Images/Mnoznik/Stripe_{color}_4.png";
                    if (File.Exists(filePath))
                    {
                        Image stripe = Image.FromFile(filePath);
                        graphics.DrawImage(stripe, new Rectangle(0, 0, width, height));
                        stripe.Dispose();
                    }
                }
            }

            resistorImagePictureBox.Image = resistorBitmap;
        }

        // Aktualizuje obraz rezystora, nakładając odpowiednie paski kolorów na tło.
        private void UpdateResistorImage()
        {
            int width = resistorImagePictureBox.Width;
            int height = resistorImagePictureBox.Height;

            Bitmap resistorBitmap = new Bitmap("Images/resistorBG.png");
            resistorBitmap = new Bitmap(resistorBitmap, new Size(width, height));

            using (Graphics graphics = Graphics.FromImage(resistorBitmap))
            {
                DrawStripe(graphics, band1ComboBox.SelectedItem?.ToString(), "Images/01_Pasek", "1", width, height);
                DrawStripe(graphics, band2ComboBox.SelectedItem?.ToString(), "Images/02_Pasek", "2", width, height);

                if (band3ComboBox.Enabled)
                {
                    DrawStripe(graphics, band3ComboBox.SelectedItem?.ToString(), "Images/03_Pasek", "3", width, height);
                }

                string multiplier = multiplierComboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(multiplier))
                {
                    DrawStripe(graphics, multiplierComboBox.SelectedItem?.ToString(), "Images/Mnoznik", "4", width, height);
                }

                string tolerance = toleranceComboBox.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(tolerance) && !tolerance.StartsWith("Brak"))
                {
                    DrawStripe(graphics, toleranceComboBox.SelectedItem?.ToString(), "Images/Tolerancja", "5", width, height);
                }

                if (temperatureComboBox.Enabled)
                {
                    DrawStripe(graphics, temperatureComboBox.SelectedItem?.ToString(), "Images/WspolczynnikTemperatury", "6", width, height);
                }
            }

            if (resistorImagePictureBox.Image != null)
            {
                resistorImagePictureBox.Image.Dispose();
            }
            resistorImagePictureBox.Image = resistorBitmap;
        }

        private string GetColorFromComboBox(string selected)
        {
            // tekst ma format "cyfra - kolor", np. "1 - brązowy"
            string colorPart = selected.Split('-')[1].Trim();
            switch (colorPart)
            {
                case "czarny": return "Black";
                case "brązowy": return "Brown";
                case "czerwony": return "Red";
                case "pomarańczowy": return "Orange";
                case "żółty": return "Yellow";
                case "zielony": return "Green";
                case "niebieski": return "Blue";
                case "fioletowy": return "Purple";
                case "szary": return "Gray";
                case "biały": return "White";
                case "złoty": return "Gold";
                case "srebny": return "Silver";
                default: return "";
            }
        }

        private void DrawStripe(Graphics graphics, string selectedItem, string folderPath, string stripeNumber, int width, int height)
        {
            if (!string.IsNullOrEmpty(selectedItem) && !selectedItem.StartsWith("Brak"))
            {
                string color = GetColorFromComboBox(selectedItem);
                string filePath = $"{folderPath}/Stripe_{color}_{stripeNumber}.png";
                if (File.Exists(filePath))
                {
                    Image stripe = Image.FromFile(filePath);
                    graphics.DrawImage(stripe, new Rectangle(0, 0, width, height));
                    stripe.Dispose();
                }
            }
        }

    }
}
