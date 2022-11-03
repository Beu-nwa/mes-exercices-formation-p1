<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2lignes="" F2para="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000" nbDecimales="8" arrondiAuto="vrai" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Quel est l'âge de votre enfant ? #1" algoitem="AFFICHER &quot; Quel est l'âge de votre enfant ? &quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="6#x &lt; 3" algoitem="SI (x &lt; 3) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#reponse#&quot; votre enfant est trop jeune ! &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant est trop jeune ! &quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6#x &lt; 7" algoitem="SI (x &lt; 7) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#reponse#&quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Baby. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Baby. &quot;"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6#x &lt; 9" algoitem="SI (x &lt; 9) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#reponse#&quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Poussin. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Poussin. &quot;"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                            <item code="9#sinon" algoitem="SINON">
                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                <item code="6#x &lt; 11" algoitem="SI (x &lt; 11) ALORS">
                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                    <item code="5#reponse#&quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Pupille. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Pupille. &quot;"/>
                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                    <item code="9#sinon" algoitem="SINON">
                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                        <item code="6#x &lt; 13" algoitem="SI (x &lt; 13) ALORS">
                                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                            <item code="5#reponse#&quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Minime. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Minime. &quot;"/>
                                            <item code="8#finsi" algoitem="FIN_SI"/>
                                            <item code="9#sinon" algoitem="SINON">
                                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                <item code="6#x &lt; 18 " algoitem="SI (x &lt; 18 ) ALORS">
                                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                                    <item code="5#reponse#&quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Cadet. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant agé de : &quot; + x + &quot; ans peut accéder à la catégorie Cadet. &quot;"/>
                                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                                    <item code="9#sinon" algoitem="SINON">
                                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                                        <item code="5#reponse#&quot; votre enfant est majeur ! &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; votre enfant est majeur ! &quot;"/>
                                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                                    </item>
                                                </item>
                                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                                            </item>
                                        </item>
                                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                                    </item>
                                </item>
                                <item code="11#finsinon" algoitem="FIN_SINON"/>
                            </item>
                        </item>
                        <item code="11#finsinon" algoitem="FIN_SINON"/>
                    </item>
                </item>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="3#reponse#1#pasliste" algoitem="AFFICHER reponse"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
