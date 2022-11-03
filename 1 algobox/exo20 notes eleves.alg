<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FIN_TANT_QUE"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param maxBoucle="500000" totalBoucles="5000000" totalAffichages="1000" epaisseurPoint="2" arrondiAuto="vrai" epaisseurLigne="2" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#n" algoitem="n EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nMin" algoitem="nMin EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#nMax" algoitem="nMax EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#m" algoitem="m EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#phrase" algoitem="phrase EST_DU_TYPE CHAINE"/>
        <item code="1#NOMBRE#t" algoitem="t EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#nMin#20#pasliste" algoitem="nMin PREND_LA_VALEUR 20"/>
        <item code="4#Vueillez saisir 20 notes !#1" algoitem="AFFICHER &quot;Vueillez saisir 20 notes !&quot;"/>
        <item code="12#i#1#20" algoitem="POUR i ALLANT_DE 1 A 20">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="5#phrase#&quot; Veuillez saisir la note n°: &quot; + i#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; Veuillez saisir la note n°: &quot; + i"/>
            <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
            <item code="2#n#pasliste" algoitem="LIRE n"/>
            <item code="15#(n &lt; 0) OU (n > 20)" algoitem="TANT_QUE ((n &lt; 0) OU (n > 20)) FAIRE">
                <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
                <item code="5#phrase#&quot; Le note &quot; + n + &quot; n'est pas valide ! Veuillez réessayer et rentrer la note n°: &quot; + i#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; Le note &quot; + n + &quot; n'est pas valide ! Veuillez réessayer et rentrer la note n°: &quot; + i"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="2#n#pasliste" algoitem="LIRE n"/>
                <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
            </item>
            <item code="6#n > nMax" algoitem="SI (n > nMax) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#nMax#n#pasliste" algoitem="nMax PREND_LA_VALEUR n"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#n &lt; nMin" algoitem="SI (n &lt; nMin) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#nMin#n#pasliste" algoitem="nMin PREND_LA_VALEUR n"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="5#m#m + n#pasliste" algoitem="m PREND_LA_VALEUR m + n"/>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="15#t != 4" algoitem="TANT_QUE (t != 4) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="4#Tapez 1 pour afficher la plus petite note.#1" algoitem="AFFICHER &quot;Tapez 1 pour afficher la plus petite note.&quot;"/>
            <item code="4#Tapez 2 pour afficher la plus grande note.#1" algoitem="AFFICHER &quot;Tapez 2 pour afficher la plus grande note.&quot;"/>
            <item code="4#Tapez 3 pour afficher la moyenne.#1" algoitem="AFFICHER &quot;Tapez 3 pour afficher la moyenne.&quot;"/>
            <item code="4# Tapez 4 pour stop #1" algoitem="AFFICHER &quot; Tapez 4 pour stop &quot;"/>
            <item code="2#t#pasliste" algoitem="LIRE t"/>
            <item code="6#t &lt; 1 OU t > 4" algoitem="SI (t &lt; 1 OU t > 4) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#&quot; Veuillez rentrer un nombre valide &quot;#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; Veuillez rentrer un nombre valide &quot;"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#t == 1" algoitem="SI (t == 1) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#&quot; la plus petite note est: &quot; + nMin#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; la plus petite note est: &quot; + nMin"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#t == 2" algoitem="SI (t == 2) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#&quot; la plus grande note est: &quot; + nMax#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; la plus grande note est: &quot; + nMax"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#t == 3" algoitem="SI (t == 3) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#&quot; la moyenne est: &quot; + (m/20)#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; la moyenne est: &quot; + (m/20)"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="6#t == 4" algoitem="SI (t == 4) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#&quot; Vous avez stoppé ! &quot;#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; Vous avez stoppé ! &quot;"/>
                <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
