To what extent did the design decisions you made when writing the original programs make it easier or harder to factor out common code?
Initial decizia de a imparti functionalitatile programului in mai mutle clase si functii a facut ca factorizarea codului comun sa fie realizata cu usurinta.

Was the way you wrote the second program influenced by writing the first?
Ne-am dat seama că al doilea program are o soluție similară cu primul program, așa că am copiat părți din implementare, le-am modificat și le-am făcut potrivite pentru al doilea program.

Is factoring out as much common code as possible always a good thing? Did the readability of the programs suffer because of this requirement? How about the maintainability?
Nu, deoarece daca folosim codul comun intr-un alt program, pot exista conflicte sau sa fie nevoie sa modificam codul comun astfel incat sa poata fi folosit in noul program. 
In cazul asta ar trebui sa fim atenti sa nu stricam alte parti din programele care folosesc codul comun. 