/**
 * Exercice26: conversion secondes
 * Author: Emds
 * Date; 27/12/22
 */
using System;

namespace Exercice26
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            int secondes;
            // saisir un nombre de secondes (entre 0 et 86400)
            do
            {
                Console.Write("Entrez un nombre de secondes (entre 0 et 86400) = ");
                secondes = int.Parse(Console.ReadLine());
            } while (secondes < 0 || secondes > 86400);
            // calcul des heures, minutes et secondes
            int h = secondes / 3600;
            int m = (secondes - (h * 3600))/60;
            int s = secondes-((h * 3600)+(m*60));
            // formatage de l'affichage
            string affichage = "";
            if (h < 10)
            {
                affichage += "0";
            }
            affichage += h + ":";
            if(m < 10)
            {
                affichage += "0";
            }
            affichage += m + ":";
            if(s < 10)
            {
                affichage += "0";
            }
            affichage += s;
            // affichage sous forme (HH-MM-SS)
            Console.WriteLine(affichage);
            Console.ReadLine();
        }
    }
}
