from posixpath import split


f = open("Instabot_setting.insbt")
temp = f.readline()
f.close()
Setting = temp.split(",")


f = open("Instabot_List.insbt")
CustumList = f.readlines()
f.close()


