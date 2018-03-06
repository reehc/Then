#! /usr/bin/python3

import pyaudio

p = pyaudio.PyAudio()
stream = p.open(...)

def aPiano():
	f = 0
	while(True):
		f = getFrequency()
		stream.write(data)
end


