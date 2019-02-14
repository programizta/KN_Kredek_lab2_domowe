using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrKoleczeklab1
{
    /// <summary>
    /// Jest to klasa 
    /// </summary>
    public partial class GameForm : Form
    {
        // komunikat wyświetlany tuż przed uruchomieniem okna gry gdy wybraliśmy nację jako ZSRR
        static string zsrrText = "Wygląda na to, że III Rzesza zaatakowała na dobre! Potężne oddziały " +
            "składające się z wielu oddziałów piechoty, czołgów PanzerKampfwagen V Panther, PanzerKampfwagen VI Tiger " +
            "oraz floty morskiej nacierają w Twoją stronę. Tylko uważaj! Może się zdarzyć, że wróg może zaatakować " +
            "w stylu 'Blitzkrieg', czyli zostaną zmobilizowane wszystkie jednostki wroga i z pełną siłą zaczną niszczyć " +
            "Twoje jednostki. Wróg posiada także możliwość ostrzału artyleryjskiego, ostrzału z floty morskiej, a także " +
            "wezwania posiłków podniebnych w postaci myśliwców i bombowców. Powodzenia!";

        // komunikat wyświetlany tuż przed uruchomieniem okna gry gdy wybraliśmy nację jako III Rzesza
        static string reichText = "Najwyższa pora rozprawić się z ZSRR! Ruszamy w bój! Musimy się przedrzeć do przodu " +
            "i zniszczyć wszystkie obiekty wroga. Co prawda mamy skończoną liczbę jednostek, ale mając flotę morską " +
            "dobrze uzbrojone czołgi oraz możliwość wezwania bombowców powinniśmy dać sobie radę!";

        // zmienna, która steruje metodą, odpowiedzialną do wywołania katastrofy
        int countCatastrophy;
        // zmienna służąca do zliczenia ile razy wezwane zostały już posiłki
        int callResources;
        // zmienna służąca do zliczenia ile razy wezwane zostało wsparcie przeciwlotnicze
        int airSupport;
        // zmienna służąca do zliczenia ile razy wezwana została już artyleria
        int artillerySupport;
        // deklaracja zmiennej typu Rand w celu pseudolosowej zmiany zasobów gracza i przeciwnika
        Random rand;
        // liczba, która jest niezbędna do generowania pseudolosowych przedziałów wykorzystywana do generowania
        // strat u wroga
        int number;
        // zmienne, które są dolnymi (lower) i górnymi (upper) ograniczeniami
        // dla generowanych strat u wroga/gracza
        int lowerFlightsPlayerNumber, upperFlightsPlayerNumber;
        int lowerTanksPlayerNumber, upperTanksPlayerNumber;
        int lowerHumanEnemyNumber, upperHumanEnemyNumber;
        int lowerFlightsEnemyNumber, upperFlightsEnemyNumber;
        int lowerTanksEnemyNumber, upperTanksEnemyNumber;
        // deklaracja zmiennych, które reprezentują jednostki wojskowe
        ReichInfantry reichInfantry;
        ReichPlanes reichPlanes;
        ReichTanks reichTanks;
        RussianInfantry russianInfantry;
        RussianPlanes russianPlanes;
        RussianTanks russianTanks;

        /// <summary>
        /// Wszystkie TextBoxy ustawiamy tylko do odczytu, żeby użytkownik
        /// nie mógł wprowadzać własnych liczb
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            textBoxYourHuman.ReadOnly = true;
            textBoxYourTanks.ReadOnly = true;
            textBoxEnemyHuman.ReadOnly = true;
            textBoxEnemyTanks.ReadOnly = true;
            textBoxYourPlanes.ReadOnly = true;
            textBoxEnemyPlanes.ReadOnly = true;
        }

        /// <summary>
        /// Metoda ustawiająca łatwy poziom gry
        /// </summary>
        private void SetEasyMode()
        {
            // tworzymy listy jednostek
            reichInfantry = new ReichInfantry(10);
            reichPlanes = new ReichPlanes(100);
            reichTanks = new ReichTanks(1000);
            russianInfantry = new RussianInfantry(7);
            russianPlanes = new RussianPlanes(65);
            russianTanks = new RussianTanks(700);
            reichInfantry.CreateListOfPlatoons();
            reichInfantry.CreatePlatoons(1000);
            reichPlanes.CreateListOfPlanes();
            reichPlanes.CreatePlanes(500);
            reichTanks.CreateListOfTanks();
            reichTanks.CreateTanks(200);
            russianInfantry.CreateListOfPlatoons();
            russianInfantry.CreatePlatoons(1000);
            russianPlanes.CreateListOfPlanes();
            russianPlanes.CreatePlanes(400);
            russianTanks.CreateListOfTanks();
            russianTanks.CreateTanks(180);
            textBoxYourHuman.Text = russianInfantry.GetCount().ToString();
            textBoxYourTanks.Text = russianTanks.GetCount().ToString();
            textBoxYourPlanes.Text = russianPlanes.GetCount().ToString();
            textBoxEnemyHuman.Text = reichInfantry.GetCount().ToString();
            textBoxEnemyTanks.Text = reichTanks.GetCount().ToString();
            textBoxEnemyPlanes.Text = reichPlanes.GetCount().ToString();
            lowerFlightsPlayerNumber = 2;
            upperFlightsPlayerNumber = 10;
            lowerTanksPlayerNumber = 2;
            upperTanksPlayerNumber = 7;
            lowerHumanEnemyNumber = 15;
            upperHumanEnemyNumber = 30;
            lowerFlightsEnemyNumber = 5;
            upperFlightsEnemyNumber = 10;
            lowerTanksEnemyNumber = 4;
            upperTanksEnemyNumber = 10;
            timerDecPlayerHumRes.Interval = 800;
            timerDecPlayerFlyRes.Interval = 700;
            timerDecPlayerTankRes.Interval = 400;
            timerDecEnHumRes.Interval = 800;
            timerDecEnFlyRes.Interval = 700;
            timerDecEnTankRes.Interval = 400;
        }

        /// <summary>
        /// Metoda ustawiająca średni poziom gry
        /// </summary>
        private void SetMediumMode()
        {
            reichInfantry = new ReichInfantry(10);
            reichPlanes = new ReichPlanes(100);
            reichTanks = new ReichTanks(1000);
            russianInfantry = new RussianInfantry(7);
            russianPlanes = new RussianPlanes(65);
            russianTanks = new RussianTanks(700);
            reichInfantry.CreateListOfPlatoons();
            reichInfantry.CreatePlatoons(1200);
            reichPlanes.CreateListOfPlanes();
            reichPlanes.CreatePlanes(520);
            reichTanks.CreateListOfTanks();
            reichTanks.CreateTanks(330);
            russianInfantry.CreateListOfPlatoons();
            russianInfantry.CreatePlatoons(1200);
            russianPlanes.CreateListOfPlanes();
            russianPlanes.CreatePlanes(500);
            russianTanks.CreateListOfTanks();
            russianTanks.CreateTanks(350);
            textBoxYourHuman.Text = russianInfantry.GetCount().ToString();
            textBoxYourTanks.Text = russianTanks.GetCount().ToString();
            textBoxYourPlanes.Text = russianPlanes.GetCount().ToString();
            textBoxEnemyHuman.Text = reichInfantry.GetCount().ToString();
            textBoxEnemyTanks.Text = reichTanks.GetCount().ToString();
            textBoxEnemyPlanes.Text = reichPlanes.GetCount().ToString();
            lowerFlightsPlayerNumber = 2;
            upperFlightsPlayerNumber = 10;
            lowerTanksPlayerNumber = 2;
            upperTanksPlayerNumber = 7;
            lowerHumanEnemyNumber = 15;
            upperHumanEnemyNumber = 30;
            lowerFlightsEnemyNumber = 5;
            upperFlightsEnemyNumber = 10;
            lowerTanksEnemyNumber = 4;
            upperTanksEnemyNumber = 10;
            timerDecPlayerHumRes.Interval = 700;
            timerDecPlayerFlyRes.Interval = 600;
            timerDecPlayerTankRes.Interval = 400;
            timerDecEnHumRes.Interval = 700;
            timerDecEnFlyRes.Interval = 600;
            timerDecEnTankRes.Interval = 400;
        }

        /// <summary>
        /// Metoda ustawiająca trudny poziom gry
        /// </summary>
        private void SetHardMode()
        {
            reichInfantry = new ReichInfantry(10);
            reichPlanes = new ReichPlanes(100);
            reichTanks = new ReichTanks(1000);
            russianInfantry = new RussianInfantry(7);
            russianPlanes = new RussianPlanes(65);
            russianTanks = new RussianTanks(700);
            reichInfantry.CreateListOfPlatoons();
            reichInfantry.CreatePlatoons(850);
            reichPlanes.CreateListOfPlanes();
            reichPlanes.CreatePlanes(115);
            reichTanks.CreateListOfTanks();
            reichTanks.CreateTanks(122);
            russianInfantry.CreateListOfPlatoons();
            russianInfantry.CreatePlatoons(1000);
            russianPlanes.CreateListOfPlanes();
            russianPlanes.CreatePlanes(110);
            russianTanks.CreateListOfTanks();
            russianTanks.CreateTanks(250);
            textBoxYourHuman.Text = russianInfantry.GetCount().ToString();
            textBoxYourTanks.Text = russianTanks.GetCount().ToString();
            textBoxYourPlanes.Text = russianPlanes.GetCount().ToString();
            textBoxEnemyHuman.Text = reichInfantry.GetCount().ToString();
            textBoxEnemyTanks.Text = reichTanks.GetCount().ToString();
            textBoxEnemyPlanes.Text = reichPlanes.GetCount().ToString();
            lowerFlightsPlayerNumber = 2;
            upperFlightsPlayerNumber = 10;
            lowerTanksPlayerNumber = 2;
            upperTanksPlayerNumber = 7;
            lowerHumanEnemyNumber = 15;
            upperHumanEnemyNumber = 30;
            lowerFlightsEnemyNumber = 5;
            upperFlightsEnemyNumber = 10;
            lowerTanksEnemyNumber = 4;
            upperTanksEnemyNumber = 10;
            timerDecPlayerHumRes.Interval = 700;
            timerDecPlayerFlyRes.Interval = 600;
            timerDecPlayerTankRes.Interval = 400;
            timerDecEnHumRes.Interval = 800;
            timerDecEnFlyRes.Interval = 650;
            timerDecEnTankRes.Interval = 400;
        }

        /// <summary>
        /// Metoda ustawiająca ekstremalny poziom gry
        /// </summary>
        private void SetExtremeMode()
        {
            reichInfantry = new ReichInfantry(10);
            reichPlanes = new ReichPlanes(100);
            reichTanks = new ReichTanks(1000);
            russianInfantry = new RussianInfantry(7);
            russianPlanes = new RussianPlanes(65);
            russianTanks = new RussianTanks(700);
            reichInfantry.CreateListOfPlatoons();
            reichInfantry.CreatePlatoons(1210);
            reichPlanes.CreateListOfPlanes();
            reichPlanes.CreatePlanes(50);
            reichTanks.CreateListOfTanks();
            reichTanks.CreateTanks(218);
            russianInfantry.CreateListOfPlatoons();
            russianInfantry.CreatePlatoons(1630);
            russianPlanes.CreateListOfPlanes();
            russianPlanes.CreatePlanes(200);
            russianTanks.CreateListOfTanks();
            russianTanks.CreateTanks(520);
            textBoxYourHuman.Text = russianInfantry.GetCount().ToString();
            textBoxYourTanks.Text = russianTanks.GetCount().ToString();
            textBoxYourPlanes.Text = russianPlanes.GetCount().ToString();
            textBoxEnemyHuman.Text = reichInfantry.GetCount().ToString();
            textBoxEnemyTanks.Text = reichTanks.GetCount().ToString();
            textBoxEnemyPlanes.Text = reichPlanes.GetCount().ToString();
            lowerFlightsPlayerNumber = 2;
            upperFlightsPlayerNumber = 10;
            lowerTanksPlayerNumber = 2;
            upperTanksPlayerNumber = 7;
            lowerHumanEnemyNumber = 15;
            upperHumanEnemyNumber = 30;
            lowerFlightsEnemyNumber = 5;
            upperFlightsEnemyNumber = 10;
            lowerTanksEnemyNumber = 4;
            upperTanksEnemyNumber = 10;
            timerDecPlayerHumRes.Interval = 700;
            timerDecPlayerFlyRes.Interval = 600;
            timerDecPlayerTankRes.Interval = 400;
            timerDecEnHumRes.Interval = 850;
            timerDecEnFlyRes.Interval = 600;
            timerDecEnTankRes.Interval = 500;
        }

        /// <summary>
        /// Metoda odpowiedzialna za wyświetlenie w messageboxie informację w przypadku wyboru nacji jako ZSRR
        /// </summary>
        private void ShowZSRRMessage()
        {
            MessageBox.Show(zsrrText);
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek ludzkich wroga
        /// Nieco enigmatyczna nazwa - DecrementEnemyHumanResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecEnHumRes_Tick(object sender, EventArgs e)
        {
            if (russianInfantry.platoons.Count() == 0)
            {
                textBoxEnemyHuman.Text = "0";
                timerDecEnHumRes.Stop();
            }
            else
            {
                number = rand.Next(lowerHumanEnemyNumber, upperHumanEnemyNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        russianInfantry.platoons.RemoveAt(0);
                        textBoxEnemyHuman.Text = russianInfantry.platoons.Count().ToString();
                    }
                }
                catch
                {
                    russianInfantry.platoons.Clear();
                    textBoxEnemyHuman.Text = russianInfantry.platoons.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek czołgowych gracza
        /// Nieco enigmatyczna nazwa - DecrementPlayerTankResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecPlayerTankRes_Tick(object sender, EventArgs e)
        {
            if (reichTanks.reichTanks.Count() == 0)
            {
                textBoxYourTanks.Text = "0";
                timerDecPlayerTankRes.Stop();
            }
            else
            {
                number = rand.Next(lowerTanksPlayerNumber, upperTanksPlayerNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        reichTanks.reichTanks.RemoveAt(0);
                        textBoxYourTanks.Text = reichTanks.reichTanks.Count().ToString();
                    }
                }
                catch
                {
                    reichTanks.reichTanks.Clear();
                    textBoxYourTanks.Text = reichTanks.reichTanks.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek czołgowych wroga
        /// Nieco enigmatyczna nazwa - DecrementEnemyTankResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecEnTankRes_Tick(object sender, EventArgs e)
        {
            if (russianTanks.russianTanks.Count() == 0)
            {
                textBoxEnemyTanks.Text = "0";
                timerDecEnTankRes.Stop();
            }
            else
            {
                number = rand.Next(lowerTanksEnemyNumber, upperTanksEnemyNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        russianTanks.russianTanks.RemoveAt(0);
                        textBoxEnemyTanks.Text = russianTanks.russianTanks.Count().ToString();
                    }
                }
                catch
                {
                    russianTanks.russianTanks.Clear();
                    textBoxEnemyTanks.Text = russianTanks.russianTanks.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek powietrznych gracza
        /// Nieco enigmatyczna nazwa - DecrementPlayerFlyingResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecPlayerFlyRes_Tick(object sender, EventArgs e)
        {
            if (reichPlanes.reichPlanes.Count() == 0)
            {
                textBoxYourPlanes.Text = "0";
                timerDecPlayerFlyRes.Stop();
            }
            else
            {
                number = rand.Next(lowerFlightsPlayerNumber, upperFlightsPlayerNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        reichPlanes.reichPlanes.RemoveAt(0);
                        textBoxYourPlanes.Text = reichPlanes.reichPlanes.Count().ToString();
                    }
                }
                catch
                {
                    reichPlanes.reichPlanes.Clear();
                    textBoxYourPlanes.Text = reichPlanes.reichPlanes.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek powietrznych wroga
        /// Nieco enigmatyczna nazwa - DecrementEnemyFlyingResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecEnFlyRes_Tick(object sender, EventArgs e)
        {
            if (russianPlanes.russianPlanes.Count() == 0)
            {
                textBoxEnemyPlanes.Text = "0";
                timerDecEnFlyRes.Stop();
            }
            else
            {
                number = rand.Next(lowerFlightsEnemyNumber, upperFlightsEnemyNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        russianPlanes.russianPlanes.RemoveAt(0);
                        textBoxEnemyPlanes.Text = russianPlanes.russianPlanes.Count().ToString();
                    }
                }
                catch
                {
                    russianPlanes.russianPlanes.Clear();
                    textBoxEnemyPlanes.Text = russianPlanes.russianPlanes.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda, która zatrzymuje działanie wszystkich czasomierzy
        /// </summary>
        private void StopAllTimers()
        {
            timerDecPlayerHumRes.Stop();
            timerDecPlayerFlyRes.Stop();
            timerDecPlayerTankRes.Stop();
            timerDecEnHumRes.Stop();
            timerDecEnFlyRes.Stop();
            timerDecEnTankRes.Stop();
            timerCheckGameResult.Stop();
        }

        /// <summary>
        /// Metoda, która kończy działanie potyczki, wyświetlany jest 
        /// odpowiedni komunikat w przypadku zwycięstwa lub porażki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCheckGameResult_Tick(object sender, EventArgs e)
        {
            if (reichInfantry.platoons.Count() == 0 && reichPlanes.reichPlanes.Count() == 0 && reichTanks.reichTanks.Count() == 0)
            {
                StopAllTimers();
                MessageBox.Show("Niestety, ale przegrałeś! Twoje wszystkie jednostki wojskowe zostały unicestwione!");
                this.Close();
            }
            else if (russianInfantry.platoons.Count() == 0 && russianPlanes.russianPlanes.Count() == 0 && russianTanks.russianTanks.Count() == 0)
            {
                StopAllTimers();
                MessageBox.Show("Sukces! Wróg został pokonany! Gratulacje!");
                this.Close();
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za wyświetlenie w messageboxie informację w przypadku wyboru nacji jako III Rzesza
        /// </summary>
        private void ShowReichText()
        {
            MessageBox.Show(reichText);
        }

        /// <summary>
        /// Inicjalizacja generatora liczb pseudolosowych, ustawienie poziomu trudności
        /// i koloru tła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            rand = new Random();
            if (FormMain.GetNation() == "reich") MessageBox.Show(reichText);
            else MessageBox.Show(zsrrText);
            this.BackColor = Color.Silver;
            if (FormMain.GetDifficulty() == "easy") SetEasyMode();
            else if (FormMain.GetDifficulty() == "medium") SetMediumMode();
            else if (FormMain.GetDifficulty() == "hard") SetHardMode();
            else SetExtremeMode();
        }

        /// <summary>
        /// Metoda odpowiedzialna za generowanie "katastrof"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRandomCatastrophy_Tick(object sender, EventArgs e)
        {
            countCatastrophy++;

            if (countCatastrophy % 31 == 0)
            {
                if (FormMain.GetNation() == "zsrr")
                {
                    MessageBox.Show("Armia Radziecka wezwała ostrzał artyleryjski na nasze pozycje!\n" +
                        "Ponosimy ogromne straty w jednostkach!");
                }
                else
                {
                    MessageBox.Show("Siły III Rzeszy zorganizowały Blitzkrieg!\n" +
                        "Nasze oddziały są dosłownie dziesiątkowane, a czołgi T-34-85 płoną!");
                }

                try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        reichInfantry.platoons.RemoveAt(0);
                    }
                }
                catch
                {
                    reichInfantry.platoons.Clear();
                }

                try
                {
                    for (int i = 0; i < 30; i++)
                    {
                        reichTanks.reichTanks.RemoveAt(0);
                    }
                }
                catch
                {
                    reichTanks.reichTanks.Clear();
                }
            }
            if (countCatastrophy % 73 == 0)
            {
                if (FormMain.GetNation() == "zsrr")
                {
                    MessageBox.Show("ZSRR ostrzeliwuje nas od strony morza i nieba!\n" +
                        "Czerwoni robią z nas prawdziwą sieczkę!");
                }
                else
                {
                    MessageBox.Show("III Rzesza postanowiła wyprowadzić na pole bitwy\n" +
                        "Tygrysy Królewskie, jednostki Panzer-Grenadierów oraz działka przeciwlotnicze Ostwind Flakpanzer!\n" +
                        "Na polu bitwy zagęściły się kłęby dymów oraz ognia!");
                }

                try
                {
                    for (int i = 0; i < 150; i++)
                    {
                        reichInfantry.platoons.RemoveAt(0);
                    }
                }
                catch
                {
                    russianInfantry.platoons.Clear();
                }

                try
                {
                    for (int i = 0; i < 50; i++)
                    {
                        reichTanks.reichTanks.RemoveAt(0);
                    }
                }
                catch
                {
                    reichTanks.reichTanks.Clear();
                }

                try
                {
                    for (int i = 0; i < 30; i++)
                    {
                        reichPlanes.reichPlanes.RemoveAt(0);
                    }
                }
                catch
                {
                    reichPlanes.reichPlanes.Clear();
                }
            }
        }

        /// <summary>
        /// Metoda uruchamiająca czasomierze gdy klikniemy przycisk "Zacznij grę!"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            timerCheckGameResult.Interval = 100;
            timerCheckGameResult.Start();
            timerRandomCatastrophy.Interval = 500;
            timerRandomCatastrophy.Start();
            timerDecEnFlyRes.Start();
            timerDecEnHumRes.Start();
            timerDecEnTankRes.Start();
            timerDecPlayerFlyRes.Start();
            timerDecPlayerHumRes.Start();
            timerDecPlayerTankRes.Start();
        }

        /// <summary>
        /// Metoda odpowiedzialna za wezwanie wsparcia powietrznego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCallPlaneSupport_Click(object sender, EventArgs e)
        {
            airSupport++;
            if (airSupport < 2)
            {
                MessageBox.Show("Działa przeciwlotnicze pracują pełną parą i zadają spory cios samolotom przeciwnika!");
                try
                {
                    for (int i = 0; i < 35; i++)
                    {
                        russianPlanes.russianPlanes.RemoveAt(0);
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Działka przeciwlotnicze zostały zbombardowane!");
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszanie jednostek ludzkich gracza
        /// Nieco enigmatyczna nazwa - DecrementPlayerHumanResources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDecPlayerHumRes_Tick(object sender, EventArgs e)
        {
            if (reichInfantry.platoons.Count() == 0)
            {
                textBoxYourHuman.Text = "0";
                timerDecPlayerHumRes.Stop();
            }
            else
            {
                number = rand.Next(lowerHumanEnemyNumber, upperHumanEnemyNumber);
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        reichInfantry.platoons.RemoveAt(0);
                        textBoxYourHuman.Text = reichInfantry.platoons.Count().ToString();
                    }
                }
                catch
                {
                    reichInfantry.platoons.Clear();
                    textBoxYourHuman.Text = reichInfantry.platoons.Count().ToString();
                }
            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za wezwanie posiłków.
        /// Zasoby ludzkie, czołgi i samoloty zostają uzupełnione u gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCallSupport_Click(object sender, EventArgs e)
        {
            callResources++;
            if (callResources <= 2)
            {
                MessageBox.Show("Posiłki są w drodze! Wnet Twoje straty w jednostkach zostaną uzupełnione");
                reichInfantry.CreatePlatoons(300);
                reichTanks.CreateTanks(50);
                reichPlanes.CreatePlanes(50);
            }
            else
            {
                MessageBox.Show("Niestety, ale wykorzystałeś wszystkie swoje posiłki, które mogłeś wezwać!");
            }
        }

        /// <summary>
        /// Metoda wzywająca ostrzał artyleryjski na wroga.
        /// Zasoby przeciwnika zostają pomniejszone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCallArtillery_Click(object sender, EventArgs e)
        {
            artillerySupport++;
            if (artillerySupport < 2)
            {
                MessageBox.Show("Operatorowi radiostacji udało się nawiązać kontakt ze wsparciem artyleryjskim! " +
                    "Pociski celnie trafiają w cel i zadają spore straty u wroga!");

                for (int i = 0; i < 150; i++)
                {
                    try
                    {
                        russianInfantry.platoons.RemoveAt(0);
                    }
                    catch
                    {
                        break;
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    try
                    {
                        russianTanks.russianTanks.RemoveAt(0);
                    }
                    catch
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ojoj! Radiooperatorowi nawaliła radiostacja! Nie wezwiemy już wsparcia artyleryjskiego!");
            }
        }
    }
}
