from code import interact
from os import times
from instabot_setting import Setting
from instabot_setting import CustumList
from instapy import InstaPy

username = Setting[0]
password = Setting[1]
target = Setting[2]
action = Setting[3]
randomize = Setting[4]
random_tags = Setting[5]
skip_top_posts = Setting[6]
interaction = Setting[7]
amount = int(Setting[8])
times = int(Setting[9])
delay = int(Setting[10])

session = InstaPy(username=username , password=password) 
session.login()

#Like Functions

if( action == "Like By Tags") : 
    session.like_by_tags(tags=CustumList , use_random_tags=random_tags , randomize=randomize , skip_top_posts=skip_top_posts,interact=interaction)
if(action == "Like By Location") : 
    session.like_by_locations(locations=CustumList, amount=amount,skip_top_posts=skip_top_posts,randomize=randomize)
if(action == "Like By Feeds") : 
    session.like_by_feed(amount=amount,randomize=randomize,interact = interaction)

#Follow Functions

if(action == "Like By List") : 
    session.follow_by_list(followlist=CustumList,times=times,sleep_delay=delay,interact=interaction)


if(action == "Follow By Tags") : 
    session.follow_by_tags(tags=CustumList)  


if(action == "Follow By Location" )   : 
    session.follow_by_locations(locations=CustumList) 


if(action == "Follow Target Followers") :
    session.follow_user_followers(usernames=CustumList)
   # session.interact_user_followers(usernames=CustumList)
   # session.set_do_follow(enabled=True, times = times )
   # session.set_do_like(enabled=True)



if(action == "Follow Target Followings")  : 
    session.follow_user_following(usernames = CustumList)



if(action == "Follow Target Likers") : 
    session.follow_likers(usernames = CustumList,)    
    #usernames: list, photos_grab_amount: int = 3, follow_likers_per_photo: int = 3, randomize: bool = True, sleep_delay: int = 600, interact: bool = False



if(action == "Follow Target Commenters") : 
    session.follow_commenters(usernames=CustumList,)   
    #amount: int = 10, daysold: int = 365, max_pic: int = 50, sleep_delay: int = 600, interact: bool = False


if(action == "Unfollow") : 
    session.unfollow_users(amount=amount)

   # Unfollow By A List
   #custom_list_enabled: bool = False, custom_list: list = [] custom_list_param: str = "all", instapy_followed_enabled: bool = False, instapy_followed_param: str = "all",

   #Unfollow Non Followers
   #nonFollowers: bool = False

   #AllFollowings
   #style: str = "FIFO", unfollow_after: int | None = None,delay_followbackers: int = 0, sleep_delay: int = 600
    
if(action == "Watch Stories") : 
    session.story_by_tags(tags=CustumList)  
    session.set_do_story()  

