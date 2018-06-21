#!/bin/bash
# Run as root.

SWIG_VERSION=3.0.12

curl -L http://prdownloads.sourceforge.net/swig/swig-$SWIG_VERSION.tar.gz | tar xvfz - && \
cd swig-$SWIG_VERSION && \
./configure && \
make -j $(nproc) && \
make install && \
cd .. && \
rm -rf swig-$SWIG_VERSION