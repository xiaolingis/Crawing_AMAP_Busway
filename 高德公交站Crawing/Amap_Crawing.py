# -*- coding: utf-8 -*-  
import requests
from bs4 import BeautifulSoup
import xlwt
'''
直辖市  
"code":"010","city":"北京", 
"code":"021","city":"上海", 
"code":"022","city":"天津", 
"code":"023","city":"重庆",
江苏  "code":"025","city":"南京", 
"code":"0512","city":"苏州", 
"code":"0519","city":"常州", 
"code":"0518","city":"连云港", 
"code":"0523","city":"泰州", 
"code":"0510","city":"无锡", 
"code":"0516","city":"徐州", 
"code":"0514","city":"扬州", 
"code":"0511","city":"镇江", 
"code":"0517","city":"淮安", 
"code":"0513","city":"南通", 
"code":"0527","city":"宿迁", 
"code":"0515","city":"盐城",
#https://www.amap.com/service/poiInfo?query_type=TQUERY&pagesize=20&pagenum=1&qii=true&cluster_state=5&need_utd=true&utd_sceneid=1000&div=PC1000&addr_poi_merge=true&is_classify=true&zoom=17&city=110000&keywords=1%E8%B7%AF%E5%85%AC%E4%BA%A4
'''