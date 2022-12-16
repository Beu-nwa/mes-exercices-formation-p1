<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER reponse"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2lignes="" F2defaut="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurPoint="2" maxBoucle="500000" totalBoucles="5000000" nbDecimales="8" arrondiAuto="vrai" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#AB" algoitem="AB EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#BC" algoitem="BC EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#CA" algoitem="CA EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Renseigner la longueur de côté AB du triangle ABC #1" algoitem="AFFICHER &quot; Renseigner la longueur de côté AB du triangle ABC &quot;"/>
        <item code="2#AB#pasliste" algoitem="LIRE AB"/>
        <item code="4# Renseigner la longueur de côté BC du triangle ABC #1" algoitem="AFFICHER &quot; Renseigner la longueur de côté BC du triangle ABC &quot;"/>
        <item code="2#BC#pasliste" algoitem="LIRE BC"/>
        <item code="4# Renseigner la longueur de côté CA du triangle ABC #1" algoitem="AFFICHER &quot; Renseigner la longueur de côté CA du triangle ABC &quot;"/>
        <item code="2#CA#pasliste" algoitem="LIRE CA"/>
        <item code="6#(AB == BC) ET (AB == CA)" algoitem="SI ((AB == BC) ET (AB == CA)) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#reponse#&quot; Le triangle est équilatéral &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est équilatéral &quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="6# AB == BC " algoitem="SI ( AB == BC ) ALORS">
                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                    <item code="5#reponse#&quot; Le triangle est isocèle en B &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est isocèle en B &quot;"/>
                    <item code="8#finsi" algoitem="FIN_SI"/>
                    <item code="9#sinon" algoitem="SINON">
                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                        <item code="6# BC == CA " algoitem="SI ( BC == CA ) ALORS">
                            <item code="7#debutsi" algoitem="DEBUT_SI"/>
                            <item code="5#reponse#&quot; Le triangle est isocèle en C &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est isocèle en C &quot;"/>
                            <item code="8#finsi" algoitem="FIN_SI"/>
                            <item code="9#sinon" algoitem="SINON">
                                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                <item code="6# CA == AB " algoitem="SI ( CA == AB ) ALORS">
                                    <item code="7#debutsi" algoitem="DEBUT_SI"/>
                                    <item code="5#reponse#&quot; Le triangle est isocèle en A &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est isocèle en A &quot;"/>
                                    <item code="8#finsi" algoitem="FIN_SI"/>
                                    <item code="9#sinon" algoitem="SINON">
                                        <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                                        <item code="5#reponse#&quot; Le triangle est quelconque &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est quelconque &quot;"/>
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
