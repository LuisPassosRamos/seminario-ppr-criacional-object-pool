---
export_on_save:
  html: true
---

# seminario-1

## Markdown


- item
- item
- item



1. valor
2. valor
3. valor

| title1 | title2 |
| ------ | ------ |
| a      | b      |


[Markdown](https://docs.github.com/pt/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)

## Plantuml

```plantuml {align="center"}
@startuml
title: Animal example
note "From Duck till Zebra" as n1
class Animal{
    +int age
    +String gender
    + boolean isMammal()
    + void mate()
}
'para a heranca ficar para baixo
class Duck extends Animal{
    +String beakColor
    +swim()
    +quack()
}
class Fish{
    -int sizeInFeet
    -canEat()
}
class Zebra{    
    +bool is_wild
    +run()
}

class Duck
note left: can fly\ncan swim\ncan dive\ncan help in debugging

'para a heranca ficar para o lado
Animal <|- Zebra 

'para a heranca ficar para baixo
Animal <|-- Fish 

@enduml
```
[PlantUML Class Diagram](https://plantuml.com/class-diagram)

## Mermaid

```mermaid {align="center"}
---
title: Animal example
---
classDiagram
    note "From Duck till Zebra"
    Animal <|-- Duck
    note for Duck "can fly\ncan swim\ncan dive\ncan help in debugging"
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
        +String beakColor
        +swim()
        +quack()
    }
    class Fish{
        -int sizeInFeet
        -canEat()
    }
    class Zebra{
        +bool is_wild
        +run()
    }

```

[Mermaid Class Diagram](https://mermaid.js.org/syntax/classDiagram.html)


## Markdown Preview Enhanced

[Markdown Preview Enhanced](https://shd101wyy.github.io/markdown-preview-enhanced/#/)


@import "src/Classe.java"

### HTML Export

[html-export](https://shd101wyy.github.io/markdown-preview-enhanced/#/html?id=html-export)


Right click at the preview, click HTML tab.
Then choose:

HTML (offline) Choose this option if you are only going to use this html file locally.
HTML (cdn hosted) Choose this option if you want to deploy your html file remotely.

![screen shot 2017-07-14 at 1 14 28 am](https://user-images.githubusercontent.com/1908863/28200455-d5a12d60-6831-11e7-8572-91d3845ce8cf.png)