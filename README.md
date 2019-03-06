# WinForms Remake of the Roulette Game

Предмет на оваа проектна задача е креирање на Windows верзија на популарната игра Рулет. Рулет е казино игра именувана по французкиот збор што во превод би значело little wheel. Во играта, играчите можат да вложуваат на бројче од 0 до 36, на групи од бројчиња, на боите црно и црвено, дали бројот е парен или непарен или дали броевите се високи(од 19 до 36) или ниски(од 1 до 18).

По завршувањето на делот од вложувањето компјутерот ги "собира" влоговите на играчите и го пушта тркалото да се врти. Тркалото има 37 бројки од 0 до 37 од кои 18 се црвени 18 се црни и една бројка е зелена а тоа е бројот 0. Секвенцата на броеви на Европскиот рулет(кој има 37 бројки за разлика од Американскиот рулет кој има 38 бројки) е 0-32-15-19-4-21-2-25-17-34-6-27-13-36-11-30-8-23-10-5-24-16-33-1-20-14-31-9-22-18-29-7-28-12-35-3-26. Броевите на рулетот се поделени на повеќе подгрупи и тоа zero spiel, big series, small series и orphans.

###Имплементација
Имплементацијата на играта е релативно едноставна и се состои од три форми. Првата форма се појавува при стартување на играта тоа претставува таблата со броевите на рулетот. И ова претставува главното платно каде се игра играта
![alt text](https://prnt.sc/jwrxd0)


Во конструкторот на формата на почетокот има инстанцата од класата ChipBet и тие претставуваат чиповите со кои играат играчите и тие исцртуваат на платното. Во дадениот пример се дадени 4 можни видови на чипови а тоа се 1, 5, 10 и 50 што значи дека играчите можат да ставаат чипови во оваа вредност. Истите тие се дадени како втор аргумент.


```
            ChipBet c = new ChipBet(new Point(400,615), 1);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(500, 615), 5);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(600, 615), 10);
            chipsDoc.AddChipBet(c);

            c = new ChipBet(new Point(700, 615), 50);
            chipsDoc.AddChipBet(c);
```
Класата ChipBet чува информации за радиусот на чипот, за вредноста на чипот и дали е селектиран од страна на играчот.

```
        public int RADIUS = 25;
        public int Digit { get; set; }
        public bool isSelected { get; set; }

        public Point Center { get; set; }

        public ChipBet(Point center, int digit)
        {
            Digit = digit;
            Center = center;
            isSelected = false;
        }
```

Функцијата Draw во класата служи за исцртување на истите тие чипови. Во случај да чипот е селектиран се зголемува радиусот на истиот тој чип и значи дека играчот продолжува да го користи тој и само тој чип. Може да се одбере само еден вид на чип.
```
public void Draw(Graphics g)
        {
            if (isSelected)
            {
                RADIUS = 35;
                g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                Font f = new Font("Arial", 15);
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 12, Center.Y - 10);
                f.Dispose();
            }
            else
            {
                RADIUS = 25;
                g.FillEllipse(Brushes.Aqua, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
                Font f = new Font("Arial", 15);
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 12, Center.Y - 10);
                f.Dispose();
            }

        }
```

Играчот одбира еден вид на чип кој ќе го користи за играње а тоа го право со десниот клик на копчето и тоа е зададено во кодот
```
private void RouletteBetScreen_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                chipsDoc.Select(e.Location);
                currentBetNumber = chipsDoc.getChipBet();
                Invalidate(true);
            }
        }
```

Следно што прави играчот откако ќе избере со кој чип ќе игра е да почне да става влогови. Има 20 секунди да ги стави своите влогови и потоа тркалото почнува на врти и одбира еден број и врз основа на тој број се пресметува добивката на истиот тој играч. На играта има повеќе buttons и зависно од кликот играчот ја повикува функцијата chipInsert од класата chipsDoc. Функцијата check() проверува дали играчот има доволно средства за да стави на посакуваното поле. Во следниот пример ќе видиме ставање на чип од вредност 50 на полето 36.
Играчот ја повикува оваа фунцкија со три аргументи и тоа Полето каде се наоѓа тоа копче(Х+20, Y+20 е средината на копчето), currentBetNumber = 50 затоа што претходно играчот со десен клик го одбрал чипот со вредност од 50 и третиот аргумент е 36 затоа штоа чуваме вредности од чиповите за кои играчот игра.

```
private void button36_Click(object sender, EventArgs e)
        {
            if (check())
            {
                chipsDoc.chipInsert(new Point(button36.Location.X + 20, button36.Location.Y + 20), currentBetNumber, 36);
            }
        }
```

Исто така во главната форма користиме и тајмер и по истекувањето на секундите кои се иницијализирани на 20, го известува играчот дека вложувањето е завршено и се повикува нова форма и тоа SpinningWheel која ни враќа random бројче од 0 до 37 и повик до функцијата checkTheResults() да провери дали сме добитни.

```
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerCall%10 == 0)
            {
                seconds--;
                label4.Text = seconds.ToString() + " seconds";
                if (seconds < 1)
                {
                    label5.Text = "The betting is over. Good luck";
                    timer1.Stop();
                    SpinningWheel form = new SpinningWheel();
                    form.rouletteBetScreen = this;
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        label6.Text = "The latest number was " + form.currentNumber.ToString();
                        currentBetNumber = form.currentNumber;
                        checkTheResults();
                    }
                }
            }
            timerCall++;
        }
```
Формата за вртење на топчето е иницијализирана со SpinningWheel form. Броевите ги ставаме во array исто така се чува и кој број каква боја е затоа што во тајмерот на оваа форма се менува позадината на бројчето зависно од тоа какво е.
```
        public int[] numbers = new int[37] { 0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26 };
        public int[] redNumbers = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public int[] blackNumbers = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
```
```
 foreach (int n in blackNumbers)
            {
                if (numbers[y % 37] == n)
                {
                label1.BackColor = Color.Black;
                break;
                }
            }
            foreach (int n in redNumbers)
            {
                if (numbers[y % 37] == n)
                {
                    label1.BackColor = Color.Red;
                    break;
                }
            }
            if(numbers[y%37] == 0)
            {
                label1.BackColor = Color.Green;
            }
```
Тајмерот на почетокот има интервал од 100 но со тек на секундите се успорува со што визуелизираме вистинско вртење на топче во SpinningWheel.
```
if (timerCall % 10 == 0)
            {
                seconds++;
                if (seconds == 2)
                    timer1.Interval = 250;
                if(seconds == 3)
                    timer1.Interval = 500;
                if (seconds == 6)
                    timer1.Interval = 700;
            }
            timerCall++;
```

По завршување на "вртењето на топчето" се чека 2 секунди со следниот код и се праќа паднатиот број назад кон главната форма со што следи и проверка дали играчот е добитен.
```
System.Threading.Thread.Sleep(2000);
```
Проверка дали играчот фатил некоја бројка или поле се прави во функцијата checkTheResults() во класата ChipsDoc. Со следниот код се проверува секој чип игран од страна на играчот. CurrentBetNumber претставува бројот пратен како аргумент од главната форма за кој број се паднал на тркалото а c.Digit претставува бројот на чипови играни на тој број.
```
foreach (Chip c in Chips)
                {
                    if (c.NumberBet == currentBetNumber)
                    {
                        currentWin += Convert.ToInt32(c.Digit * 36);
                        break;
                    }
                }
```
По завршување на проверката се ресетираат секундите и играчот повторно има 20 секунди за да ги стави.

# Пријатно играње!
