# EntityCodeFirst
@Auteur : Hervé LABENERE Générer une base de données à partir du code source Application Asp.net MVC très simple pour générer la table Produits depuis le code source C# de la classe Produit. 
Basée sur Entity Framework 6.4 Et voici le tuto dont je me suis inspiré : https://docs.microsoft.com/fr-fr/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

Prérequis : Version récente de Visual Studio 

0)Créer dans VS une application de type Asp.net MVC
1)Installer EntityFramework via le gestionnaire de packages intégré à Visual Studio NuGet
2)Créer dans le dossier Models, la classe/Entité Produit 
3)Créer un dossier DAL (Couche d'accès aux données ou Data Access Layer) 
4)Dans ce dossier créer une classe avec le contexte de base de données qui pointe sur le fichier WebConfig 
5)Et créer une classe d'initialisation de la base et de la table Produit où la méthode Seed remplit la base de données 6)Modifier le fichier Web.Config à la racine de l'application pour pointer sur cette classe d'initialisation et dans la chaine de connexion faire le lien avec le contexte de base de données 7)Tester la génération de la base avec une vue basique comme Index.cshtml
