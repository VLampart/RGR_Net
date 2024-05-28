import threading
import time

class ReadWriteLock:
    def __init__(self):
        self._read_lock = threading.Lock()
        self._write_lock = threading.Lock()
        self._readers = 0
        self._stop_threads = False

    def acquire_read(self):
        with self._read_lock:
            self._readers += 1
            if self._readers == 1:
                self._write_lock.acquire()

    def release_read(self):
        with self._read_lock:
            self._readers -= 1
            if self._readers == 0:
                self._write_lock.release()

    def acquire_write(self):
        self._write_lock.acquire()

    def release_write(self):
        self._write_lock.release()

    def stop_threads(self):
        self._stop_threads = True

    def should_stop(self):
        return self._stop_threads

# Демонстрація використання
def read(lock, id):
    while not lock.should_stop():
        lock.acquire_read()
        print(f'Reader {id} is reading')
        lock.release_read()
        time.sleep(1)

def write(lock, id):
    while not lock.should_stop():
        lock.acquire_write()
        print(f'Writer {id} is writing')
        lock.release_write()
        time.sleep(1)

if __name__ == "__main__":
    rw_lock = ReadWriteLock()

    # Створення потоків для читачів
    readers = []
    for i in range(5):
        reader_thread = threading.Thread(target=read, args=(rw_lock, i))
        readers.append(reader_thread)
        reader_thread.start()

    # Створення потоків для письменників
    writers = []
    for i in range(2):
        writer_thread = threading.Thread(target=write, args=(rw_lock, i))
        writers.append(writer_thread)
        writer_thread.start()

    # Зупинка потоків після деякого часу
    time.sleep(10)
    rw_lock.stop_threads()
    
    # Чекаємо завершення потоків
    for reader in readers:
        reader.join()

    for writer in writers:
        writer.join()

    print("All threads have finished.")
