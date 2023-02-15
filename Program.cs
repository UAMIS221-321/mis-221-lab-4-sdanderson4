// start main
int userChoice = GetUserChoice();
while(userChoice!=3){
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}
// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    // Console.Clear();
    System.Console.WriteLine();
    System.Console.WriteLine("Enter 1 to Display Full Triangle\nEnter 2 to Display Partial Triangle\nEnter 3 to Exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice=="1" || userChoice=="2" || userChoice=="3") {
        return true;
    }
    return false;
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2 ) {
        GetPartial();
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void GetFull() {
    Random rand = new Random();
    int number  = rand.Next(7);
    number = 3 + number;
    for(int i = 0; i <= number; i++) {
        for(int j = 0; j < i; j++){
            System.Console.Write("0");
        }
        System.Console.WriteLine();
    }
}

static void GetPartial() {
    Random rand = new Random();
    int number  = rand.Next(7);
    number = 3 + number;


    for(int i = 0; i <= number; i++) {

        for(int j = 0; j < i; j++){
            Random ran = new Random();
            int numb = ran.Next(2);
            numb = 1 + numb;
            if (numb == 1) {
                System.Console.Write("0");
            }
            else if (numb == 2) {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine();
    }
}