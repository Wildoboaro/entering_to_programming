import os
def clear_console():
    os.system('cls')

clear_console()


quantity_ref = 9
ref1 = "osfjwoiergwoignaewpjofwoeijfnwfonewfoignewtowenffnoeiwowjfninoiwfen"
ref2 = "anton"
ref3 = "aoooooooooontooooo"
ref4 = "elelelelelelelelelel"
ref5 = "ntoneeee"
ref6 = "tonee"
ref7 = "253235235a5323352n25235352t253523523235oo235523523523n"
ref8 = "antoooooooooooooooooooooooooooooooooooooooooooooooooooon"
ref9 = "untone"
refs = [ref1, ref2, ref3, ref4, ref5, ref6, ref7, ref8, ref9] 


wrld = "anton"
def adw_srch(world, obj):
 
    j = 0
    flag = False
    for i in obj:
        # print(i, world[j])
        if i == world[j]:
            j = j + 1
        if j >= len(world):
            flag = True
            return(flag)

for k in range(quantity_ref):
    flag = adw_srch(wrld, refs[k])
    # print(refs[k], flag)
    if flag:
        print(k+1)