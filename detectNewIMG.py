import os
import time
import telepot
starttime = time.time()
folder_path = r'C:\Users\s9403\OneDrive\桌面\VCRbot\img'
count = 0
the_file_list = []
pre_file_list =[]

while True:
    the_file_list = []
    list_of_files = os.listdir(folder_path)
    for file_name in list_of_files:
        the_file_list.append(file_name)
    if len(the_file_list) != len(pre_file_list):
        # send notify to bot
        print("新照片來囉")
        setNow = set(the_file_list)
        setPre = set(pre_file_list)
        added = list(sorted(setNow - setPre))
        print('added:',added[0])

        strcut_time = time.localtime(time.time())
        time_send = time.strftime("%Y-%m-%d- %H:%M",strcut_time)
        bot = telepot.Bot('5026727343:AAGHof_rWhLjKS32SV3fUo_0LY6kZc5z2eo')
        bot.sendPhoto('2077239473', photo=open('img/'+added[0], 'rb'),caption= time_send+" 抓 有人沒戴口罩!")

    pre_file_list = the_file_list
    time.sleep(3.0 - (time.time() - starttime) % 3.0) # wait for 1s