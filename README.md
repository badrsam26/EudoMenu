# Eudonet Exercice de recrutement

## TACHES A EFFECTUER

### 1 - ARCHITECTURER L’APPLICATION

pour cet excercice, j'ai pris en compte la perspective à long terme, car après le développement de l'API, il est probable qu'il y ait d'autres développements qui l'utiliseront, tels qu'une Web SPA, une application mobile, etc. Pour garantir une architecture solide, évolutive et maintenable, j'ai opté pour la Clean/Onion Architecture avec les principes:
* CQRS (Command and Query Responsibility Segregation) Pattern
* Mediator pour la gestion/organisation des dependences
* EF Core (ORM)
* Swagger : documentation et test des endpoints exposé par l'API

Je fais ce choix parce que je suis convaincu que cette approche favorise la séparation claire des fonctionnalités et la modularité du système. En utilisant l'architecture Onion Architecture, nous sommes en mesure de créer des applications qui sont plus faciles à tester, à maintenir et à faire évoluer. La structure en couches de cette architecture permet de garder les différentes responsabilités du système bien isolées, ce qui facilite les modifications et les mises à jour ultérieures. De plus, la modularité offerte par cette architecture permet d'ajouter de nouvelles fonctionnalités ou de modifier des parties spécifiques de l'application sans affecter le reste du système. Sans oublier la réduction des dépendances. Tout cela donne confiance que l'application sera capable de s'adapter et de répondre aux besoins futurs de manière efficace. 
En revanche, il est important de noter que l'utilisation cette architecture peut introduire une complexité accrue en raison de la présence de multiples couches. Cette complexité supplémentaire peut rendre la compréhension et la maintenance du système plus difficiles, surtout pour les développeurs moins familiers avec ce type d'architecture. 

### 2 - Lister les différentes couches de l’application

* Domain
* Application
* Infrastructure: Persistence
* UI

### 3 - Schéma de base de données
![Schéma de base de données](https://i.ibb.co/6bXK33z/schema-bd.jpg)

### 4 - Le schéma de flux entre les couches pour les fonctionnalités
![Le schéma de flux entre les couches pour les fonctionnalités](https://i.ibb.co/4t0B3Ht/flux.png)

### 5 - SPECIFICATIONS DES DEVELOPPEMENTS

Pour entamer les développements suivants une bonne conprehension de la Clean Architecture, MediatR et le pattern CQRS, est indispensable. Je vous recommande de consulter cet article : https://binodmahto.medium.com/clean-code-architecture-with-mediator-cqrs-pattern-in-net-core-7cec4ee51fc3

#### 1)Voici les étapes à suivre pour ajouter un nouveau restaurant en respectant cette architecture :

Dans la couche "Application", précisément dans le projet "Application", naviguez vers le dossier qui regroupe toutes les fonctionnalités liées aux restaurants. Ajoutez un nouveau dossier dans la partie "Commands" pour la nouvelle fonctionnalité : "CreateRestaurant".

1)Commencez par la création du ViewModel pour représenter les données du restaurant.

2)Créez la commande de création qui sera utilisée par le (handler).

3)N'oubliez pas de définir les règles de validation de la commande à l'aide de FluentValidation.

4)Créez le (handler) qui se chargera de l'exécution de la commande en utilisant le (repository) qui gère les restaurants.

5)Définissez le mapping entre "Restaurant" et le ViewModel dans les profiles.

6)Dans le projet "API", dans le contrôleur "RestaurantController", ajoutez la méthode POST qui permettra l'envoi de la commande à l'aide de MediatR pour ajouter un restaurant.

7)N'oubliez pas de réaliser des tests unitaires pour vérifier le bon fonctionnement de la méthode que vous avez créée.

Il est important de noter que, dans le lexique utilisé, on parle de requête (query) lorsqu'il s'agit de récupération de données, et de commande (command) lorsqu'il s'agit de création, modification ou suppression de données.

Assurez-vous de suivre ces étapes en comprenant les concepts de la Clean Architecture, de MediatR et du pattern CQRS pour développer de manière cohérente et maintenable.