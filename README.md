# whisper-GUI
a GUI for whisper that could Speech to Text offline. whisper的GUI版本，离线将音视频的语音转文字，支持多语言和GPU

##### 这是一个使用生成bat来操作的GUI，很草，但能用

使用前请先安装python，比如python3.10，在python官网上下载并且勾选“add path”

然后安装whisper[https://github.com/openai/whisper]:

可以使用下面的命令行安装whisper

```bash
pip install -U openai-whisper
```

或者

```bash
pip install git+https://github.com/openai/whisper.git 
```

To小白：还可以在后面换源加速，比如
```bash
pip install -U openai-whisper -i 	http://mirrors.aliyun.com/pypi/simple/
```


然后需要一个ffmpeg，不会设置path的小白可以直接互联往上下一个ffmpeg.exe丢到C:\Windows\System32里面

安装好以后就可以使用这个GUI版本了

![image](https://user-images.githubusercontent.com/82741331/213493215-c5fbe086-4cc1-443c-af6f-024a9e527654.png)

两个选择框是切换语言和模型

具体可以看whisper的github：

|  Size  | Parameters | English-only model | Multilingual model | Required VRAM | Relative speed |
|:------:|:----------:|:------------------:|:------------------:|:-------------:|:--------------:|
|  tiny  |    39 M    |     `tiny.en`      |       `tiny`       |     ~1 GB     |      ~32x      |
|  base  |    74 M    |     `base.en`      |       `base`       |     ~1 GB     |      ~16x      |
| small  |   244 M    |     `small.en`     |      `small`       |     ~2 GB     |      ~6x       |
| medium |   769 M    |    `medium.en`     |      `medium`      |     ~5 GB     |      ~2x       |
| large  |   1550 M   |        N/A         |      `large`       |    ~10 GB     |       1x       |

左边选单是想要保存的格式，会自动保存在音视频文件旁边。

点击下面好长的那条用以选择文件，会把文件添加到列表。

点击Start即可开始啦！
