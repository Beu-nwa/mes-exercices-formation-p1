<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2etat="inactif" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalAffichages="1000" maxBoucle="500000" epaisseurLigne="2" arrondiAuto="vrai" nbDecimales="8" epaisseurPoint="2" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="p EST_DU_TYPE NOMBRE" code="1#NOMBRE#p"/>
        <item algoitem="t EST_DU_TYPE NOMBRE" code="1#NOMBRE#t"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Quel est votre poids ? &quot;" code="4#Quel est votre poids ? #1"/>
        <item algoitem="LIRE p" code="2#p#pasliste"/>
        <item algoitem="AFFICHER &quot;Quel est votre taille ? &quot;" code="4#Quel est votre taille ? #1"/>
        <item algoitem="LIRE t" code="2#t#pasliste"/>
        <item algoitem="SI ( (p>=43 ET t>=145) ET ((p&lt;66 ET t&lt;161) OU (p&lt;60 ET t&lt;164) OU (p&lt;54 ET t&lt;167) OU (p&lt;48 ET t&lt;170)) ) ALORS" code="6# (p>=43 ET t>=145) ET ((p&lt;66 ET t&lt;161) OU (p&lt;60 ET t&lt;164) OU (p&lt;54 ET t&lt;167) OU (p&lt;48 ET t&lt;170)) ">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="reponse PREND_LA_VALEUR &quot; votre profil correspond à la Taille 1 &quot;" code="5#reponse#&quot; votre profil correspond à la Taille 1 &quot;#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="SI (((p>=48 ET p&lt;54) ET (t>=169 ET t&lt;179)) OU ((p>=54 ET p&lt;60) ET (t>=166 ET t&lt;176)) OU ((p>=60 ET p&lt;66) ET (t>=163 ET t&lt;173)) OU ((p>=66 ET p&lt;72) ET (t>=160 ET t&lt;=170))) ALORS" code="6#((p>=48 ET p&lt;54) ET (t>=169 ET t&lt;179)) OU ((p>=54 ET p&lt;60) ET (t>=166 ET t&lt;176)) OU ((p>=60 ET p&lt;66) ET (t>=163 ET t&lt;173)) OU ((p>=66 ET p&lt;72) ET (t>=160 ET t&lt;=170))">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="reponse PREND_LA_VALEUR &quot; votre profil correspond à la Taille 2 &quot;" code="5#reponse#&quot; votre profil correspond à la Taille 2 &quot;#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI ((p&lt;78 ET t&lt;184) ET ((p>=72 ET t>=163) OU (p>=66 ET t>=172) OU (p>=60 ET t>=175) OU (p>=54 ET t>=178))) ALORS" code="6#(p&lt;78 ET t&lt;184) ET ((p>=72 ET t>=163) OU (p>=66 ET t>=172) OU (p>=60 ET t>=175) OU (p>=54 ET t>=178))">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="reponse PREND_LA_VALEUR &quot; votre profil correspond à la Taille 3 &quot;" code="5#reponse#&quot; votre profil correspond à la Taille 3 &quot;#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="reponse PREND_LA_VALEUR &quot; votre profil ne correspond à aucune taille &quot;" code="5#reponse#&quot; votre profil ne correspond à aucune taille &quot;#pasliste"/>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
