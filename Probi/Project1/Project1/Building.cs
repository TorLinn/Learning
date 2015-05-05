//  класс с информацией о зданиях

using System;

class Building {
    public int Floors;      //  количество этажей
    public int Area;        //  общая площадь здания
    public int Occupants;   //  количество жильцов

    //  конструктор класса Building

    public Building(int f, int a, int o) {
        Floors = f;
        Area = a;
        Occupants = o;
    }

    //  вывести площадь на одного человека

    public int AreaPerPerson() {
        return Area / Occupants;
    }

    //  возвратить максимальное количество человек, занимающих здание,
    //  исходя из заданной минимальной площади на одного человека

    public int MaxOccupant(int minArea) {
        return Area / minArea;
    }
}