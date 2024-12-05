# Exercici 1
## Detalla el càlcul del mètode recursiu següent pels valors de num indicats, tal com hem fet a classe. Quina funcionalitat executa el mètode? (2 punts):
- num=2
- num = 12
!(./imatges/Recur1.png)

# Exercici 4
CMP -> 00 MOV-> 01 ADD -> 10  BEQ -> 11
a) 2 16

# Exercici 6

## Casos d'equivalència

tot de lletres
tot de numeros
lletres y numeros
entre 5 i 12 caracters
més de 12 caracters
menys de 5 caracters
Mayúscules
minúscules
Comença en un número
no comenza en un numero
acaba en un número
no acaba en un número

## valors limits:
### Caracters
5 caracters
12 caracters
4 caracters
6 caracters
11 caracters
13 caracters


## Casos de prova
|Nombre|que fa| input| com ho fa| resultat esperat| resultat obtingut|
-----------------------------------------------------------------------
|Char5|comprova si la mida es correcte| "abcd"| es correcte| es correcte|
|Char12| comprova si la mida es correcte| "A2i37223454A"| es correcte| es correcte|
|Char4|comprova si la mida es correcte| "AiiA"| no es correcte| no es correcte|
|Char6|comprova si la mida es correcte|"Aa6AAA"|es correcte| es correcte|
|Char11|comprova si la mida es correcte|"A666666666A"| es correcte| es correcte|
|Char13|comprova si la mida es correcte|"S38748374637A"| no es correcte| no es correcte|
|NumStart| Comprova si el no hi ha un numero davant ni darrere|"2bcde"| no es correcte| no es correcte|
|NumFin| Comprova si no hi ha un numero davant ni darrera| "abcde2""| no es correcte| no es correcte|
|AllNums| Comprova si no hi ha un numero davant ni darrera| "12345678901"| no es correcte| no es ocrrecte|
