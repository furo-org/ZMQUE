# ZMQ for UE4

A ZMQ/cppzmq wrapper plugin for UE4.

## Files in this repository

Following binary files under Source/ThridParty/zmqLibrary/ are compiled with [vcpkg](https://github.com/Microsoft/vcpkg) tool from [libzmq source distribution(c971445)](https://github.com/zeromq/libzmq/tree/c971445025535b9f989ab0b78f5ddd1c026f1878).

    libzmq-mt-4_3_1.dll
    libzmq-mt-4_3_1.lib
    libzmq-mt-gd-4_3_1.dll
    libzmq-mt-gd-4_3_1.lib
    libzmq-mt-gd-4_3_1.pdb

Header files in Source/zmq/Public/, except zmq.hpp and zmq_nt.hpp zmq_addon.hpp are taken from [the libzmq distribution](https://github.com/zeromq/libzmq/tree/c971445025535b9f989ab0b78f5ddd1c026f1878).

Header files zmq.hpp and zmq_addon.hpp in a directory Source/zmq/Public are from [cppzmq-v4.2.2 distribution](https://github.com/zeromq/cppzmq/releases/tag/v4.2.2).
A header file zmq_nt.hpp is a modified version of zmq.hpp which can compile without exception handling enabled.

Original documentations and license notices of libzmq and cppzmq are included in docs directory.

## Usage

TODO
