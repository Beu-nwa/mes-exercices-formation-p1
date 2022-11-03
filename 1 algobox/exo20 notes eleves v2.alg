<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_TANT_QUE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2defaut="" F2lignes="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurPoint="2" epaisseurLigne="2" totalAffichages="1000" nbDecimales="8" maxBoucle="500000" arrondiAuto="vrai" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="nMin EST_DU_TYPE NOMBRE" code="1#NOMBRE#nMin"/>
        <item algoitem="nMax EST_DU_TYPE NOMBRE" code="1#NOMBRE#nMax"/>
        <item algoitem="m EST_DU_TYPE NOMBRE" code="1#NOMBRE#m"/>
        <item algoitem="phrase EST_DU_TYPE CHAINE" code="1#CHAINE#phrase"/>
        <item algoitem="t EST_DU_TYPE NOMBRE" code="1#NOMBRE#t"/>
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="t PREND_LA_VALEUR 100" code="5#t#100#pasliste"/>
        <item algoitem="nMin PREND_LA_VALEUR 20" code="5#nMin#20#pasliste"/>
        <item algoitem="AFFICHER &quot; Entrer le nombre 99 pour arréter à tout moment &quot;" code="4# Entrer le nombre 99 pour arréter à tout moment #1"/>
        <item algoitem="AFFICHER &quot;Combien de note devez vous rentrer ?&quot;" code="4#Combien de note devez vous rentrer ?#1"/>
        <item algoitem="LIRE x" code="2#x#pasliste"/>
        <item algoitem="TANT_QUE (x&lt;0) FAIRE" code="15#x&lt;0">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="phrase PREND_LA_VALEUR &quot; Vous avez rentré : &quot; + x + &quot; , cette valeur n'est pas valable &quot;" code="5#phrase#&quot; Vous avez rentré : &quot; + x + &quot; , cette valeur n'est pas valable &quot;#pasliste"/>
            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
            <item algoitem="LIRE x" code="2#x#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="TANT_QUE (x!=99 ET n!=99) FAIRE" code="15#x!=99 ET n!=99">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="phrase PREND_LA_VALEUR &quot; Vous avez choisi de rentrer : &quot; + x + &quot; notes.&quot;" code="5#phrase#&quot; Vous avez choisi de rentrer : &quot; + x + &quot; notes.&quot;#pasliste"/>
            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
            <item algoitem="POUR i ALLANT_DE 1 A x" code="12#i#1#x">
                <item algoitem="DEBUT_POUR" code="13#debutpour"/>
                <item algoitem="phrase PREND_LA_VALEUR &quot; Veuillez saisir la note n°: &quot; + i" code="5#phrase#&quot; Veuillez saisir la note n°: &quot; + i#pasliste"/>
                <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                <item algoitem="LIRE n" code="2#n#pasliste"/>
                <item algoitem="TANT_QUE (((n &lt; 0) OU (n > 20)) ET n!=99) FAIRE" code="15#((n &lt; 0) OU (n > 20)) ET n!=99">
                    <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
                    <item algoitem="phrase PREND_LA_VALEUR &quot; Le note &quot; + n + &quot; n'est pas valide ! Veuillez réessayer et rentrer la note n°: &quot; + i" code="5#phrase#&quot; Le note &quot; + n + &quot; n'est pas valide ! Veuillez réessayer et rentrer la note n°: &quot; + i#pasliste"/>
                    <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                    <item algoitem="LIRE n" code="2#n#pasliste"/>
                    <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
                </item>
                <item algoitem="SI (n > nMax) ALORS" code="6#n > nMax">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="nMax PREND_LA_VALEUR n" code="5#nMax#n#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                </item>
                <item algoitem="SI (n &lt; nMin) ALORS" code="6#n &lt; nMin">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="nMin PREND_LA_VALEUR n" code="5#nMin#n#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                </item>
                <item algoitem="m PREND_LA_VALEUR m + n" code="5#m#m + n#pasliste"/>
                <item algoitem="SI (n == 99) ALORS" code="6#n == 99">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="i PREND_LA_VALEUR x" code="5#i#x#pasliste"/>
                    <item algoitem="t PREND_LA_VALEUR 0" code="5#t#0#pasliste"/>
                    <item algoitem="AFFICHER &quot; Vous avez arrété le programme ! &quot;" code="4# Vous avez arrété le programme ! #1"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                </item>
                <item algoitem="FIN_POUR" code="14#finpour"/>
            </item>
            <item algoitem="TANT_QUE (t != 0) FAIRE" code="15#t != 0">
                <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
                <item algoitem="AFFICHER &quot;Tapez 1 pour afficher la plus petite note.&quot;" code="4#Tapez 1 pour afficher la plus petite note.#1"/>
                <item algoitem="AFFICHER &quot;Tapez 2 pour afficher la plus grande note.&quot;" code="4#Tapez 2 pour afficher la plus grande note.#1"/>
                <item algoitem="AFFICHER &quot;Tapez 3 pour afficher la moyenne.&quot;" code="4#Tapez 3 pour afficher la moyenne.#1"/>
                <item algoitem="AFFICHER &quot; Tapez 0 pour stop &quot;" code="4# Tapez 0 pour stop #1"/>
                <item algoitem="LIRE t" code="2#t#pasliste"/>
                <item algoitem="SI (t == 1) ALORS" code="6#t == 1">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="phrase PREND_LA_VALEUR &quot; la plus petite note est: &quot; + nMin" code="5#phrase#&quot; la plus petite note est: &quot; + nMin#pasliste"/>
                    <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI (t == 2) ALORS" code="6#t == 2">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="phrase PREND_LA_VALEUR &quot; la plus grande note est: &quot; + nMax" code="5#phrase#&quot; la plus grande note est: &quot; + nMax#pasliste"/>
                            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="SI (t == 3) ALORS" code="6#t == 3">
                                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                    <item algoitem="phrase PREND_LA_VALEUR &quot; la moyenne est: &quot; + (m/x)" code="5#phrase#&quot; la moyenne est: &quot; + (m/x)#pasliste"/>
                                    <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                                    <item algoitem="FIN_SI" code="8#finsi"/>
                                    <item algoitem="SINON" code="9#sinon">
                                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                        <item algoitem="SI (t == 0) ALORS" code="6#t == 0">
                                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                                            <item algoitem="phrase PREND_LA_VALEUR &quot; Vous avez stoppé ! &quot;" code="5#phrase#&quot; Vous avez stoppé ! &quot;#pasliste"/>
                                            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                                            <item algoitem="FIN_SI" code="8#finsi"/>
                                            <item algoitem="SINON" code="9#sinon">
                                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                                <item algoitem="phrase PREND_LA_VALEUR &quot; Veuillez rentrer un nombre valide &quot;" code="5#phrase#&quot; Veuillez rentrer un nombre valide &quot;#pasliste"/>
                                                <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                                            </item>
                                        </item>
                                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                                    </item>
                                </item>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
            </item>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
