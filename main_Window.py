import tkinter as tk
import pyautogui
import tkinter.messagebox as messagebox
import time
import Backend



fenster = tk.Tk()
fenster.resizable(True, True)
fenster.title("Nova Autoclicker")
fenster.geometry("500x500")

tk.Button(fenster, text="test center mouse", command=pyautogui.center)


