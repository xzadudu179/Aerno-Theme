# -*- coding: utf-8 -*-

from functools import wraps

class BotCommand:
    """
    bot command

    params: tuple: params
    name: str: command name
    start_str: str: command start with
    """
    def __init__(self, params:tuple, name:str, start_str='/'):
        self.params = params
        self.start_str = start_str
        self.name = name


    def __call__(self, func):
        @wraps(func)
        async def decorated(*args, **kwargs):
            group = kwargs["group"]
            url = kwargs["url"]
            message_received: str = kwargs["message_received"]
            command_start = self.start_str + self.name + " "
            if not message_received.startswith(command_start):
                return False
            # Params
            if len(self.params) <= 0:
                return await func(messages=message_received[len(command_start):], url=url, group=group)
            params_part = message_received[len(command_start):]
            params = params_part.split(" ")
            # Clear
            params = [param for param in params if param]
            return await func(params=params, messages=params[-1], url=url, group=group)
        return decorated

def message_send(msg: str, receiver: str, url: str):
    format_message = {
        'msg': msg,
        'receiver': receiver
    }

@BotCommand(name="chat")
async def chat(message_received, url: str, group: str):
    await message_send("Hello, I'm a bot!", url=url, receiver=group.wxid)

class test:
    def __init__(self, params:tuple, name:str, start_str='/'):
        self.params = params
        self.start_str = start_str
        self.name = name

if __name__ == "__main__":
    newtest = test()