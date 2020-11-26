//Maya ASCII 2020 scene
//Name: watch tower.ma
//Last modified: Wed, Nov 04, 2020 09:52:18 PM
//Codeset: 1252
requires maya "2020";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2020";
fileInfo "version" "2020";
fileInfo "cutIdentifier" "201911140446-42a737a01c";
fileInfo "osv" "Microsoft Windows 10 Technical Preview  (Build 19042)\n";
fileInfo "UUID" "3C162B87-41B8-52B0-A262-10B467FCF099";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "47EB02B7-4C5C-4B49-8EEF-5B9D876E7EC3";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 8.8123645729817071 7.3601067288725659 -14.134334034155451 ;
	setAttr ".r" -type "double3" -12.938352729670241 147.80000000005219 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "17B94827-4EF4-618F-F74A-0CA1668977CC";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 16.968151083797082;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" 0 3.5608943820535073 -0.1405365731726107 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "3FC663B1-4A69-FC49-EE8D-01A8B9394AB9";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "1094B0C1-4B13-D97F-C685-EE8D185787ED";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	rename -uid "6468D589-4D7E-50CF-9C9F-FEA67E76AB6B";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "CB57FBB3-4E8D-93D7-65B5-2FA6F2B40D08";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	rename -uid "78854A9B-4552-1EA7-C24C-CF99F4C4B573";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "0E5A7CED-430C-8906-D5D2-DE81058708EC";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "pCube17";
	rename -uid "6BD23BFD-4374-FA5B-2581-358CCA43049B";
	setAttr ".rp" -type "double3" 0.8833187073469162 2.4156519220322408 0.36059231121597013 ;
	setAttr ".sp" -type "double3" 0.8833187073469162 2.4156519220322408 0.36059231121597013 ;
createNode mesh -n "pCube17Shape" -p "pCube17";
	rename -uid "9128054B-4E72-23D8-224E-12AC68227CF5";
	setAttr -k off ".v";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:89]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 210 ".uvst[0].uvsp[0:209]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375
		 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375
		 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1
		 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25
		 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125
		 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75
		 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0
		 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.875
		 0 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375
		 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375
		 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1
		 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25
		 0.625 0.5 0.375 0.5 0.625 0.75 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125
		 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75
		 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.375 0.25
		 0.625 0.25 0.625 0 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875
		 0.25 0.875 0 0.125 0 0.125 0.25 0.375 0 0.375 0.25 0.625 0.25 0.625 0 0.375 0.5 0.625
		 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0.25 0.875 0 0.125 0 0.125 0.25 0.375
		 0 0.375 0.25 0.625 0.25 0.625 0 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1
		 0.625 1 0.875 0.25 0.875 0 0.125 0 0.125 0.25 0.375 0 0.375 0.25 0.625 0.25 0.625
		 0 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0.25 0.875 0 0.125
		 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.5 0.375 0.5 0.625 0.75
		 0.375 0.75 0.625 1 0.375 1 0.875 0 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 120 ".vt[0:119]"  -0.026089106 3.35240936 1.31486404 0.096900746 3.35240936 1.31486404
		 -0.026089106 4.61927128 1.31486404 0.096900746 4.61927128 1.31486404 -0.026089106 4.61927128 1.19187415
		 0.096900746 4.61927128 1.19187415 -0.026089106 3.35240936 1.19187415 0.096900746 3.35240936 1.19187415
		 1.68091583 3.35240936 -0.42890173 1.80390573 3.35240936 -0.42890173 1.68091583 4.61927128 -0.42890173
		 1.80390573 4.61927128 -0.42890173 1.68091583 4.61927128 -0.55189157 1.80390573 4.61927128 -0.55189157
		 1.68091583 3.35240936 -0.55189157 1.80390573 3.35240936 -0.55189157 1.68091583 3.35240936 1.43138564
		 1.80390573 3.35240936 1.43138564 1.68091583 4.61927128 1.43138564 1.80390573 4.61927128 1.43138564
		 1.68091583 4.61927128 1.30839574 1.80390573 4.61927128 1.30839574 1.68091583 3.35240936 1.30839574
		 1.80390573 3.35240936 1.30839574 -0.061494924 3.35240936 -0.42890173 0.061494924 3.35240936 -0.42890173
		 -0.061494924 4.61927128 -0.42890173 0.061494924 4.61927128 -0.42890173 -0.061494924 4.61927128 -0.55189157
		 0.061494924 4.61927128 -0.55189157 -0.061494924 3.35240936 -0.55189157 0.061494924 3.35240936 -0.55189157
		 -0.28478557 4.77672911 1.76936197 -0.29212648 4.60900831 1.76936197 2.038267851 4.67505121 1.76936197
		 2.030926943 4.50733042 1.76936197 2.038267851 4.67505121 -1.048177242 2.030926943 4.50733042 -1.048177242
		 -0.28478557 4.77672911 -1.048177242 -0.29212648 4.60900831 -1.048177242 2.061496973 3.4479866 1.49043095
		 2.05866909 3.7725358 1.49119937 2.056742668 3.44776416 1.5668788 2.053914785 3.77231336 1.5676471
		 -0.21417969 3.42831182 1.42559445 -0.21700758 3.75286102 1.42636287 -0.20942539 3.42853427 1.34914672
		 -0.21225327 3.75308347 1.34991503 1.96876562 3.45118332 -0.63240409 1.95359874 3.7753911 -0.63240409
		 1.9705261 3.45126557 -0.55582857 1.95535922 3.77547336 -0.55582857 1.41883039 3.42545652 -0.54311717
		 1.40366352 3.74966431 -0.54311717 1.41706991 3.42537427 -0.61969268 1.40190303 3.74958205 -0.61969268
		 -0.081392437 3.44010973 1.55699253 -0.096559308 3.76431727 1.55699253 -0.15790457 3.43653035 1.55699253
		 -0.17307144 3.7607379 1.55699253 -0.15790457 3.43653035 -0.71840358 -0.17307144 3.7607379 -0.71840358
		 -0.081392437 3.44010973 -0.71840358 -0.096559308 3.76431727 -0.71840358 -0.20841521 3.3693397 1.55699253
		 2.089675665 3.3693397 1.55699253 -0.20841521 3.44593549 1.55699253 2.089675665 3.44593549 1.55699253
		 -0.20841521 3.44593549 -0.71840358 2.089675665 3.44593549 -0.71840358 -0.20841521 3.3693397 -0.71840358
		 2.089675665 3.3693397 -0.71840358 2.0079448223 3.44010973 1.55699253 1.99277806 3.76431727 1.55699253
		 1.93143272 3.43653035 1.55699253 1.91626585 3.7607379 1.55699253 1.93143272 3.43653035 -0.71840358
		 1.91626585 3.7607379 -0.71840358 2.0079448223 3.44010973 -0.71840358 1.99277806 3.76431727 -0.71840358
		 1.74666715 3.23246884 0.99484789 1.4373939 3.22537661 0.99963069 1.82536757 0.066562653 1.38923025
		 1.51609433 0.059470415 1.39401305 1.82923579 0.10490012 1.69621301 1.51996255 0.097807884 1.7009958
		 1.75053537 3.27080631 1.30183065 1.44126213 3.26371408 1.30661345 1.67172575 3.27526283 -0.33341154
		 1.36315107 3.25288892 -0.33546349 1.90347862 0.10564423 -0.62410522 1.59490395 0.083270311 -0.62615716
		 1.90347862 0.07738781 -0.31600669 1.59490395 0.055013895 -0.31805864 1.67172575 3.24700642 -0.02531302
		 1.36315107 3.2246325 -0.027364969 0.31550345 3.24443197 -0.34374142 0.0078719007 3.275702 -0.33334261
		 -0.015406693 0.08287406 -0.62612998 -0.32303825 0.11414409 -0.61573124 -0.0078719007 0.054574728 -0.31812757
		 -0.31550345 0.085844755 -0.30772877 0.32303825 3.21613264 -0.035738975 0.015406693 3.24740267 -0.02534017
		 0.3063435 3.20388174 0.98397505 -0.0015708522 3.23407936 0.98397505 -0.0024147348 0.055557609 1.40518367
		 -0.31032908 0.085754991 1.40518367 0.0015708522 0.096197486 1.71186864 -0.3063435 0.12639487 1.71186864
		 0.31032908 3.24452162 1.29066002 0.0024147348 3.27471924 1.29066002 0.49953827 3.45118332 -0.63240409
		 0.48437139 3.7753911 -0.63240409 0.50129879 3.45126557 -0.55582857 0.48613188 3.77547336 -0.55582857
		 -0.050396949 3.42545652 -0.54311717 -0.065563828 3.74966431 -0.54311717 -0.052157432 3.42537427 -0.61969268
		 -0.067324311 3.74958205 -0.61969268;
	setAttr -s 180 ".ed";
	setAttr ".ed[0:165]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0 3 5 0 4 6 0
		 5 7 0 6 0 0 7 1 0 8 9 0 10 11 0 12 13 0 14 15 0 8 10 0 9 11 0 10 12 0 11 13 0 12 14 0
		 13 15 0 14 8 0 15 9 0 16 17 0 18 19 0 20 21 0 22 23 0 16 18 0 17 19 0 18 20 0 19 21 0
		 20 22 0 21 23 0 22 16 0 23 17 0 24 25 0 26 27 0 28 29 0 30 31 0 24 26 0 25 27 0 26 28 0
		 27 29 0 28 30 0 29 31 0 30 24 0 31 25 0 32 33 0 34 35 0 36 37 0 38 39 0 32 34 0 33 35 0
		 34 36 0 35 37 0 36 38 0 37 39 0 38 32 0 39 33 0 40 41 0 42 43 0 44 45 0 46 47 0 40 42 0
		 41 43 0 42 44 0 43 45 0 44 46 0 45 47 0 46 40 0 47 41 0 48 49 0 50 51 0 52 53 0 54 55 0
		 48 50 0 49 51 0 50 52 0 51 53 0 52 54 0 53 55 0 54 48 0 55 49 0 56 57 0 58 59 0 60 61 0
		 62 63 0 56 58 0 57 59 0 58 60 0 59 61 0 60 62 0 61 63 0 62 56 0 63 57 0 64 65 0 66 67 0
		 68 69 0 70 71 0 64 66 0 65 67 0 66 68 0 67 69 0 68 70 0 69 71 0 70 64 0 71 65 0 72 73 0
		 74 75 0 76 77 0 78 79 0 72 74 0 73 75 0 74 76 0 75 77 0 76 78 0 77 79 0 78 72 0 79 73 0
		 80 81 0 82 83 0 84 85 0 86 87 0 80 82 0 81 83 0 82 84 0 83 85 0 84 86 0 85 87 0 86 80 0
		 87 81 0 88 89 0 90 91 0 92 93 0 94 95 0 88 90 0 89 91 0 90 92 0 91 93 0 92 94 0 93 95 0
		 94 88 0 95 89 0 96 97 0 98 99 0 100 101 0 102 103 0 96 98 0 97 99 0 98 100 0 99 101 0
		 100 102 0 101 103 0 102 96 0 103 97 0 104 105 0 106 107 0 108 109 0 110 111 0 104 106 0
		 105 107 0 106 108 0 107 109 0 108 110 0 109 111 0;
	setAttr ".ed[166:179]" 110 104 0 111 105 0 112 113 0 114 115 0 116 117 0 118 119 0
		 112 114 0 113 115 0 114 116 0 115 117 0 116 118 0 117 119 0 118 112 0 119 113 0;
	setAttr -s 90 -ch 360 ".fc[0:89]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13
		f 4 12 17 -14 -17
		mu 0 4 14 15 16 17
		f 4 13 19 -15 -19
		mu 0 4 17 16 18 19
		f 4 14 21 -16 -21
		mu 0 4 19 18 20 21
		f 4 15 23 -13 -23
		mu 0 4 21 20 22 23
		f 4 -24 -22 -20 -18
		mu 0 4 15 24 25 16
		f 4 22 16 18 20
		mu 0 4 26 14 17 27
		f 4 24 29 -26 -29
		mu 0 4 28 29 30 31
		f 4 25 31 -27 -31
		mu 0 4 31 30 32 33
		f 4 26 33 -28 -33
		mu 0 4 33 32 34 35
		f 4 27 35 -25 -35
		mu 0 4 35 34 36 37
		f 4 -36 -34 -32 -30
		mu 0 4 29 38 39 30
		f 4 34 28 30 32
		mu 0 4 40 28 31 41
		f 4 36 41 -38 -41
		mu 0 4 42 43 44 45
		f 4 37 43 -39 -43
		mu 0 4 45 44 46 47
		f 4 38 45 -40 -45
		mu 0 4 47 46 48 49
		f 4 39 47 -37 -47
		mu 0 4 49 48 50 51
		f 4 -48 -46 -44 -42
		mu 0 4 43 52 53 44
		f 4 46 40 42 44
		mu 0 4 54 42 45 55
		f 4 48 53 -50 -53
		mu 0 4 56 57 58 59
		f 4 49 55 -51 -55
		mu 0 4 59 58 60 61
		f 4 50 57 -52 -57
		mu 0 4 61 60 62 63
		f 4 51 59 -49 -59
		mu 0 4 63 62 64 65
		f 4 -60 -58 -56 -54
		mu 0 4 57 66 67 58
		f 4 58 52 54 56
		mu 0 4 68 56 59 69
		f 4 60 65 -62 -65
		mu 0 4 70 71 72 73
		f 4 61 67 -63 -67
		mu 0 4 73 72 74 75
		f 4 62 69 -64 -69
		mu 0 4 75 74 76 77
		f 4 63 71 -61 -71
		mu 0 4 77 76 78 79
		f 4 -72 -70 -68 -66
		mu 0 4 71 80 81 72
		f 4 70 64 66 68
		mu 0 4 82 70 73 83
		f 4 72 77 -74 -77
		mu 0 4 84 85 86 87
		f 4 73 79 -75 -79
		mu 0 4 87 86 88 89
		f 4 74 81 -76 -81
		mu 0 4 89 88 90 91
		f 4 75 83 -73 -83
		mu 0 4 91 90 92 93
		f 4 -84 -82 -80 -78
		mu 0 4 85 94 95 86
		f 4 82 76 78 80
		mu 0 4 96 84 87 97
		f 4 84 89 -86 -89
		mu 0 4 98 99 100 101
		f 4 85 91 -87 -91
		mu 0 4 101 100 102 103
		f 4 86 93 -88 -93
		mu 0 4 103 102 104 105
		f 4 87 95 -85 -95
		mu 0 4 105 104 106 107
		f 4 -96 -94 -92 -90
		mu 0 4 99 108 109 100
		f 4 94 88 90 92
		mu 0 4 110 98 101 111
		f 4 96 101 -98 -101
		mu 0 4 112 113 114 115
		f 4 97 103 -99 -103
		mu 0 4 115 114 116 117
		f 4 98 105 -100 -105
		mu 0 4 117 116 118 119
		f 4 99 107 -97 -107
		mu 0 4 119 118 120 121
		f 4 -108 -106 -104 -102
		mu 0 4 113 122 123 114
		f 4 106 100 102 104
		mu 0 4 124 112 115 125
		f 4 108 113 -110 -113
		mu 0 4 126 127 128 129
		f 4 109 115 -111 -115
		mu 0 4 129 128 130 131
		f 4 110 117 -112 -117
		mu 0 4 131 130 132 133
		f 4 111 119 -109 -119
		mu 0 4 133 132 134 135
		f 4 -120 -118 -116 -114
		mu 0 4 127 136 137 128
		f 4 118 112 114 116
		mu 0 4 138 126 129 139
		f 4 124 121 -126 -121
		mu 0 4 140 141 142 143
		f 4 126 122 -128 -122
		mu 0 4 141 144 145 142
		f 4 128 123 -130 -123
		mu 0 4 144 146 147 145
		f 4 130 120 -132 -124
		mu 0 4 146 148 149 147
		f 4 125 127 129 131
		mu 0 4 143 142 150 151
		f 4 -129 -127 -125 -131
		mu 0 4 152 153 141 140
		f 4 136 133 -138 -133
		mu 0 4 154 155 156 157
		f 4 138 134 -140 -134
		mu 0 4 155 158 159 156
		f 4 140 135 -142 -135
		mu 0 4 158 160 161 159
		f 4 142 132 -144 -136
		mu 0 4 160 162 163 161
		f 4 137 139 141 143
		mu 0 4 157 156 164 165
		f 4 -141 -139 -137 -143
		mu 0 4 166 167 155 154
		f 4 148 145 -150 -145
		mu 0 4 168 169 170 171
		f 4 150 146 -152 -146
		mu 0 4 169 172 173 170
		f 4 152 147 -154 -147
		mu 0 4 172 174 175 173
		f 4 154 144 -156 -148
		mu 0 4 174 176 177 175
		f 4 149 151 153 155
		mu 0 4 171 170 178 179
		f 4 -153 -151 -149 -155
		mu 0 4 180 181 169 168
		f 4 160 157 -162 -157
		mu 0 4 182 183 184 185
		f 4 162 158 -164 -158
		mu 0 4 183 186 187 184
		f 4 164 159 -166 -159
		mu 0 4 186 188 189 187
		f 4 166 156 -168 -160
		mu 0 4 188 190 191 189
		f 4 161 163 165 167
		mu 0 4 185 184 192 193
		f 4 -165 -163 -161 -167
		mu 0 4 194 195 183 182
		f 4 168 173 -170 -173
		mu 0 4 196 197 198 199
		f 4 169 175 -171 -175
		mu 0 4 199 198 200 201
		f 4 170 177 -172 -177
		mu 0 4 201 200 202 203
		f 4 171 179 -169 -179
		mu 0 4 203 202 204 205
		f 4 -180 -178 -176 -174
		mu 0 4 197 206 207 198
		f 4 178 172 174 176
		mu 0 4 208 196 199 209;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "71DD9225-48F3-B3F4-4851-4993DB44DF4B";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "5AA2E6EC-4FC4-9B13-9FA1-4B9E833DCA46";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "23538166-468C-6C59-3AF0-8980B142274F";
createNode displayLayerManager -n "layerManager";
	rename -uid "F98360C3-4301-A307-E321-B38C6BDC935A";
createNode displayLayer -n "defaultLayer";
	rename -uid "CCE24D5C-4537-CDD7-1DAF-728AE92731AA";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "DEF28507-4669-AAA8-8BB3-32AD1D5EE28C";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "8D89EE0D-4D53-C7E7-196B-97A58985F37A";
	setAttr ".g" yes;
createNode groupId -n "groupId1";
	rename -uid "F4FB76A2-45A9-18C6-92E3-7084F73D1381";
	setAttr ".ihi" 0;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "groupId1.id" "pCube17Shape.iog.og[0].gid";
connectAttr ":initialShadingGroup.mwc" "pCube17Shape.iog.og[0].gco";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCube17Shape.iog.og[0]" ":initialShadingGroup.dsm" -na;
connectAttr "groupId1.msg" ":initialShadingGroup.gn" -na;
// End of watch tower.ma