# The Deployment
This document helps you to deploy the project on ubuntu 18.04


# Update OS
```
    sudo apt update
    sudo apt upgrade
````
    
Install Some dev tools
```
Install some dev tools
```

# Making User ready
```
hostnamectl set-hostname django-server
```
check if it's ok by:
```
hostname
```
edit the hosts file 
```
vim /etc/hosts
```
add the following line under localhost
```
SERVER_IP   django-server
```

Then add the dev user
```
adduser dev
adduser dev sudo
```

# Firewall And Keys
we can add ufw and ssh keys to connect to the vps

# Install Requirements 
```
sudo apt install python3-pip python3-dev nginx git 
```
 
git clone the project 
```
git clone git_url
```

# VirtualEnv
```
sudo apt install virtualenvwrapper
sudo apt install virtualenv
sudo -H pip3 install --upgrade pip
sudo -H pip3 install virtualenv
```

## VirtualEnv Config
add this .bashrc it's in home
```
sudo vim .bashrc

...
export VIRTUALENVWRAPPER_PYTHON=/usr/bin/python3
export WORKON_HOME=~/Envs
source /usr/local/bin/virtualenvwrapper.sh
```

check for wrapper location and python location 
```
whereis python3
sudo find / -name "virtualenvwrapper.sh"
```
reload .bashrc
```
source ~/.bashrc

mkvirtualenv venv
workon venv
source venv/bin/activate
```
if it didn't work with python3
```
mkvirtualenv --python=/usr/bin/python3 venv
```

# Install Django
```
pip install django djangorestframework gunicorn

# Configing gunicorn
create file /etc/systemd/system/gunicorn.socket
```
[Unit]
Description=gunicorn socket

[Socket]
ListenStream=/run/gunicorn.sock

[Install]
WantedBy=sockets.target
```

create file /etc/systemd/system/gunicorn.service
```
[Unit]
Description=gunicorn daemon
Requires=gunicorn.socket
After=network.target

[Service]
User=dev
Group=www-data
WorkingDirectory=/home/dev/london_tv/backend/londonTV
ExecStart=/home/dev/Envs/eleos/bin/gunicorn \
          --access-logfile - \
          --workers 3 \
          --bind unix:/run/gunicorn.sock \
          LondonTV.wsgi:application

[Install]
WantedBy=multi-user.target
```

activate it
```
sudo systemctl start gunicorn.socket
sudo systemctl enable gunicorn.socket
```

# Nginx Config 
edit or add in sites enabled /etc/nginx/sites-available/taskturtle
```
server {
    listen 80;
    server_name IP_ADDRESS;

    location = /favicon.ico {
        access_log off;
        log_not_found off;
    }

    location /static/ {
        alias /path/to/static/;
    }

    location /media/ {
        alias /path/to/media/;
    }

    location / {
        include proxy_params;
        proxy_pass http://unix:/run/gunicorn.sock;
    }
}
```

at the end restart the nginx 
```
sudo systemctl restart nginx 
```


