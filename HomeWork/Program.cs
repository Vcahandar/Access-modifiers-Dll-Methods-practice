#region task1(Calculator)
//using HomeWork.Models;

//Calculator calcul = new Calculator();

//calcul.Calculation(12, 11);
#endregion


#region Task2(Employee)
//using HomeWork.Models;
//using System.Globalization;

//Employee emplo = new Employee();

//{
//    emplo.Name = "Cahandar";
//    emplo.Surname = "Velibeyli";
//    emplo.Age = 26;
//    emplo.Sallary = 2000;

//};

//Employee emplo2 = new Employee();

//{
//    emplo2.Name = "Ismayil";
//    emplo2.Surname = "Yusifov";
//    emplo2.Age = 27;
//    emplo2.Sallary = 950;

//};

//Employee emplo3 = new Employee();

//{
//    emplo3.Name = "Nurlan";
//    emplo3.Surname = "Mecidli";
//    emplo3.Age = 35;
//    emplo3.Sallary = 1500;

//};

//Employee emplo4 = new Employee();

//{
//    emplo4.Name = "Vuqar";
//    emplo4.Surname = "Memmedov";
//    emplo4.Age = 19;
//    emplo4.Sallary = 750;

//};


//Employee[] people = { emplo, emplo2, emplo3, emplo4 };


//WageSystem(people);

//static  void WageSystem(Employee[]people)
//{
//    bool check = false;
//    foreach (var item in people)
//    {
//        if (item.Sallary>1000||item.Sallary>2000)
//        {
//            Console.WriteLine($"{item.Name}--{item.Surname}--{item.Age}-- Maash {item.Sallary}");
//            check = true;
//        }

//    }

//    if (!check)
//    {
//        Console.WriteLine("Maashi 1000 - 2000 arasinda olanlar yoxdur!");
//    }
//}




#endregion


#region Task3(Doctor)


//using HomeWork.Models;
//using System.Data;
//using System.Xml.Schema;






//DateTime max = new DateTime(2002, 12, 15);
//DateTime min = new DateTime(1993, 05, 25);

//var doctors = GetDoctors();

//List(doctors, max, min);
//static void List(Doctor[] doctors, DateTime max, DateTime min)
//{
//    foreach (var item in doctors)
//    {
//        if (item.Birthday < max && item.Birthday > min)
//        {
//            Console.WriteLine($"{item.Name} {item.Surname} {item.Addres}   {item.Birthday}");
//        }


//    }


//}


//static Doctor[] GetDoctors()
//{

//    Doctor doc = new Doctor()
//    {
//        Name = "Cahandar",
//        Surname = "Velibeyli",
//        Addres = "Ehmedli",

//        Birthday = new DateTime(1993, 05, 25),


//    };


//    Doctor doc2 = new Doctor()
//    {
//        Name = "Mirze",
//        Surname = "Besirzade",
//        Addres = "Xirdalan",

//        Birthday = new DateTime(1996, 07, 16),


//    };


//    Doctor doc3 = new Doctor()
//    {
//        Name = "Aysu",
//        Surname = "Xellilova",
//        Addres = "Xetai",

//        Birthday = new DateTime(1999, 06, 25),


//    };


//    Doctor doc4 = new Doctor()
//    {
//        Name = "Nigar",
//        Surname = "Bekirova",
//        Addres = "Ecemi",
//        Birthday = new DateTime(2002, 12, 15),


//    };




//    Doctor doc5 = new Doctor()
//    {
//        Name = "Hecer",
//        Surname = "Ve;iyeva",
//        Addres = "Siyezen",
//        Birthday = new DateTime(1994, 08, 19),


//    };

//    Doctor doc6 = new Doctor()
//    {
//        Name = "Zaur",
//        Surname = "Qurbanov",
//        Addres = "Bayil",
//        Birthday = new DateTime(1985, 12, 27),


//    };



//    Doctor[] docArr = { doc, doc2, doc3, doc4, doc5, doc6 };
//    return docArr;




//}







#endregion


#region Task4(ServiceLayer)
//5) Service adinda layer yaradirsiz. Onun icerisinde CustomMath classi yaradirsiz. Hemin clasin icinde ashagidaki methodlar olacaq. Methodlari esas projectde (program.cs -de cagirib istifade edin).
//     Faktorialin hesablanmasi.
//     Arrayin icindeki tek ededlerin sayinin tapilmasi.


//using ServiceLayer;

//CustomMath customMath = new CustomMath();
//customMath.Factorial();

//CustomMath customMath2= new CustomMath();
//customMath2.Nums();

#endregion


#region ClassTask---1

//using HomeWork;
//using System.Reflection.PortableExecutable;

//ClassTaskPerson person = new ClassTaskPerson()
//{
//    Name = "Azer",
//    Surname="Memmedov",
//    Age=31
//};

//ClassTaskPerson person2 = new ClassTaskPerson()
//{
//    Name = "Arzu",
//    Surname = "Xellilova",
//    Age = 17
//};

//ClassTaskPerson person3 = new ClassTaskPerson()
//{
//    Name = "Kenan",
//    Surname = "Sadiqov",
//    Age = 26
//};

//ClassTaskPerson person4 = new ClassTaskPerson()
//{
//    Name = "Elcin",
//    Surname = "Memmedov",
//    Age = 18
//};

//ClassTaskPerson[] people = {person,person2, person3, person4};

//static void GetPersonsByAge(ClassTaskPerson[]people)
//{
//    foreach (var item in people)
//    {
//        if (item.Age>20)
//        {
//            Console.WriteLine($"{item.Name} {item.Surname} {item.Age}");
//        }


//    }


//}


//GetPersonsByAge(people);

#endregion

#region ClassTask---2

using HomeWork;

ClassTaskPerson__2 classTask = new ClassTaskPerson__2("Azer", "Xelilov", 26);
ClassTaskPerson__2 classTask2 = new ClassTaskPerson__2("Arzu", "Memmedov", 18);
ClassTaskPerson__2 classTask3 = new ClassTaskPerson__2("Xelil", "Talibov", 25);
ClassTaskPerson__2 classTask4 = new ClassTaskPerson__2("Arzu", "Yusifov", 19);

ClassTaskPerson__2[] people = { classTask, classTask2, classTask3, classTask4 };

personList(people);

static void personList(ClassTaskPerson__2[] people)
{
	foreach (ClassTaskPerson__2 item in people)
	{
		if (item.Age>20)
		{
			Console.WriteLine($"{item.Name} {item.Surname} {item.Age}" );
		}
	}


}














#endregion

