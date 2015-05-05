//  класс с демонстрацией информации о зданиях из класса Building

using System;

class BuildingDemo
{
    static public void BDemo()
    {
        Building house = new Building(2, 250, 4);    //  создать объект типа Building 1
        Building oficce = new Building(3, 450, 25);   //  создать объект типа Building 2

        Console.WriteLine("Дом имеет:\n " + house.Floors + " этажа\n" + house.Occupants + " жильца\n" + house.Area + 
                          " кв. метров общей площади. из них " + house.AreaPerPerson() + " приходится на одного человека");
        Console.WriteLine("При норме в 25 кв. метров на человека максимально допустимое количество людей - " + house.MaxOccupant(25));
        Console.WriteLine();

        Console.WriteLine("Учреждение имеет:\n " + oficce.Floors + " этажа\n" + oficce.Occupants + " жильца\n" + oficce.Area + 
                          " кв. метров общей площади. из них " + oficce.AreaPerPerson() + " приходится на одного человека");
        Console.WriteLine("При норме в 25 кв. метров на человека максимально допустимое количество людей - " + oficce.MaxOccupant(25));
    }
}