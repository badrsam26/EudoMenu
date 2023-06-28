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

* Application Core: Domain services, Abstraction, Interfaces, Business logic ...
* Infrastructure: Persistence
* UI

### 3 - Schéma de base de données
![Schéma de base de données](https://i.ibb.co/6bXK33z/schema-bd.jpg)

### 4 - Le schéma de flux entre les couches pour les fonctionnalités
![Le schéma de flux entre les couches pour les fonctionnalités](https://i.ibb.co/4t0B3Ht/flux.png)