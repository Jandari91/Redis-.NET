
import time
import sys

time_arg = sys.argv[1]

print (f"Sleep {time_arg} seconds from now on...")

time.sleep(int(time_arg))

print("wake up!")