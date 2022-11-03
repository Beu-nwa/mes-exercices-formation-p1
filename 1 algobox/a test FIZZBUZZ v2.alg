<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER phrase"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" epaisseurLigne="2" nbDecimales="8" arrondiAuto="vrai" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#A" algoitem="A EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nFizzBuzz" algoitem="nFizzBuzz EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nFizz" algoitem="nFizz EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nBuzz" algoitem="nBuzz EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nUndefined" algoitem="nUndefined EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#phrase" algoitem="phrase EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#moins" algoitem="moins EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Vous allez jouer à FizzBuzz, Entrez une valeur ! #1" algoitem="AFFICHER &quot; Vous allez jouer à FizzBuzz, Entrez une valeur ! &quot;"/>
        <item code="2#A#pasliste" algoitem="LIRE A"/>
        <item code="6#A &lt; 0" algoitem="SI (A &lt; 0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#A#-A#pasliste" algoitem="A PREND_LA_VALEUR -A"/>
            <item code="5#moins#&quot;-&quot;#pasliste" algoitem="moins PREND_LA_VALEUR &quot;-&quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
        </item>
        <item code="12#i#0#A" algoitem="POUR i ALLANT_DE 0 A A">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="6#i % 15 == 0" algoitem="SI (i % 15 == 0) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="4#fizzbuzz#1" algoitem="AFFICHER &quot;fizzbuzz&quot;"/>
                <item code="5#nFizzBuzz#nFizzBuzz + 1#pasliste" algoitem="nFizzBuzz PREND_LA_VALEUR nFizzBuzz + 1"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="6#i % 5 == 0" algoitem="SI (i % 5 == 0) ALORS">
                        <item code="7#debutsi" algoitem="DEBUT_SI"/>
                        <item code="4#buzz#1" algoitem="AFFICHER &quot;buzz&quot;"/>
                        <item code="5#nBuzz#nBuzz + 1#pasliste" algoitem="nBuzz PREND_LA_VALEUR nBuzz + 1"/>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                        <item code="9#sinon" algoitem="SINON">
                            <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                            <item code="6#i % 3 == 0" algoitem="SI (i % 3 == 0) ALORS">
                                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                <item code="4#fizz#1" algoitem="AFFICHER &quot;fizz&quot;"/>
                                <item code="5#nFizz#nFizz + 1#pasliste" algoitem="nFizz PREND_LA_VALEUR nFizz + 1"/>
                                <item code="8#finsi" algoitem="FIN_SI"/>
                                <item code="9#sinon" algoitem="SINON">
                                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                    <item code="3#moins#0#pasliste" algoitem="AFFICHER moins"/>
                                    <item code="3#i#1#pasliste" algoitem="AFFICHER i"/>
                                    <item code="5#nUndefined#nUndefined + 1#pasliste" algoitem="nUndefined PREND_LA_VALEUR nUndefined + 1"/>
                                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                                </item>
                            </item>
                            <item code="11#finsinon" algoitem="FIN_SINON"/>
                        </item>
                    </item>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="4# Le jeu comprend #0" algoitem="AFFICHER &quot; Le jeu comprend &quot;"/>
        <item code="5#phrase#nFizz + &quot; multiples de 3, &quot; + nBuzz + &quot; multiples de 5, &quot; + nFizzBuzz + &quot; multiples à la fois de 3 et de 5, et &quot; + nUndefined + &quot; valeurs ni multiples de 3 ni de 5. &quot;#pasliste" algoitem="phrase PREND_LA_VALEUR nFizz + &quot; multiples de 3, &quot; + nBuzz + &quot; multiples de 5, &quot; + nFizzBuzz + &quot; multiples à la fois de 3 et de 5, et &quot; + nUndefined + &quot; valeurs ni multiples de 3 ni de 5. &quot;"/>
        <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
        <item code="5#phrase#&quot;fizzbuzz terminé&quot;#pasliste" algoitem="phrase PREND_LA_VALEUR &quot;fizzbuzz terminé&quot;"/>
        <item code="3#phrase#0#pasliste" algoitem="AFFICHER phrase"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
