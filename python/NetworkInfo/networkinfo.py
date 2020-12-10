import psutil
import speedtest
from tabulate import tabulate

######################################################
# Class to output the details of the local interfaces
######################################################
class MyNetwork_Details(object):
    def __init__(self):
        self.parser = psutil.net_if_addrs()

    def __repr__(self):
        self.interfaces = []
        self.address_ip = []
        self.netmask_ip = []
        self.broadcast_ip = []

        for interface_name, interface_addresses in self.parser.items():
            self.interfaces.append(interface_name)

            for address in interface_addresses:
                if str(address.family) == 'AddressFamily.AF_INET':
                    self.address_ip.append(address.address)
                    self.netmask_ip.append(address.netmask)
                    self.broadcast_ip.append(address.broadcast)

        data = {"Interface"     : [*self.interfaces],
                "IP Address"    : [*self.address_ip],
                "Netmask"       : [*self.netmask_ip],
                "Broadcast-IP"  : [*self.broadcast_ip]
                }

        return tabulate(data, headers="keys", tablefmt="github")


##############################################################
# Class to test the internet speed of the current external nic
##############################################################
class Local_SpeedTest(object):

    def __init__(self):
        self.parser = psutil.net_if_addrs()
        self.speed_parser = speedtest.Speedtest()
        self.interfaces = self.interface()[0]

    def interface(self):
        interfaces = []

        for interface_name, _ in self.parser.items():
                interfaces.append(str(interface_name))
        
        return interfaces

    def __repr__(self):
        down = str(f"{round(self.speed_parser.download() / 1_000_000, 2)} Mbps")
        up = str(f"{round(self.speed_parser.upload() / 1_000_000, 2)} Mbps")
        interface = self.interfaces

        data = {"Interface:" : [interface],
                "Download:" : [down],
                "Upload:" : [up]}

        table = tabulate(data, headers="keys", tablefmt="pretty")
        return table


# check that we are the main script running
if __name__ == "__main__":

        # print out the current network details
        print("\n\nCurrent Network Configuration is:\n\n")
        print(MyNetwork_Details())
        print("\n\n Please wait while I test the internet speed\n\n")
        print(Local_SpeedTest())