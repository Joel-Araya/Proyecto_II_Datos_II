# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.17

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Disable VCS-based implicit rules.
% : %,v


# Disable VCS-based implicit rules.
% : RCS/%


# Disable VCS-based implicit rules.
% : RCS/%,v


# Disable VCS-based implicit rules.
% : SCCS/s.%


# Disable VCS-based implicit rules.
% : s.%


.SUFFIXES: .hpux_make_needs_suffix_list


# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /home/joel/Descargas/clion-2020.3.2/bin/cmake/linux/bin/cmake

# The command to remove a file.
RM = /home/joel/Descargas/clion-2020.3.2/bin/cmake/linux/bin/cmake -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/joel/Escritorio/Proyecto_II_Datos_II

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/Proyecto_II_Datos_II.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/Proyecto_II_Datos_II.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/Proyecto_II_Datos_II.dir/flags.make

CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o: CMakeFiles/Proyecto_II_Datos_II.dir/flags.make
CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o -c /home/joel/Escritorio/Proyecto_II_Datos_II/main.cpp

CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/joel/Escritorio/Proyecto_II_Datos_II/main.cpp > CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.i

CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/joel/Escritorio/Proyecto_II_Datos_II/main.cpp -o CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.s

CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o: CMakeFiles/Proyecto_II_Datos_II.dir/flags.make
CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o: ../src/Backtraking/Backtracking.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Building CXX object CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o -c /home/joel/Escritorio/Proyecto_II_Datos_II/src/Backtraking/Backtracking.cpp

CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/joel/Escritorio/Proyecto_II_Datos_II/src/Backtraking/Backtracking.cpp > CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.i

CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/joel/Escritorio/Proyecto_II_Datos_II/src/Backtraking/Backtracking.cpp -o CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.s

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o: CMakeFiles/Proyecto_II_Datos_II.dir/flags.make
CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o: ../src/PathfindingA/PathfindingAStar.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_3) "Building CXX object CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o -c /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/PathfindingAStar.cpp

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/PathfindingAStar.cpp > CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.i

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/PathfindingAStar.cpp -o CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.s

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o: CMakeFiles/Proyecto_II_Datos_II.dir/flags.make
CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o: ../src/PathfindingA/StarNode.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_4) "Building CXX object CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o -c /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/StarNode.cpp

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/StarNode.cpp > CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.i

CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/joel/Escritorio/Proyecto_II_Datos_II/src/PathfindingA/StarNode.cpp -o CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.s

# Object files for target Proyecto_II_Datos_II
Proyecto_II_Datos_II_OBJECTS = \
"CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o" \
"CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o" \
"CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o" \
"CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o"

# External object files for target Proyecto_II_Datos_II
Proyecto_II_Datos_II_EXTERNAL_OBJECTS =

Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/main.cpp.o
Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/src/Backtraking/Backtracking.cpp.o
Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/PathfindingAStar.cpp.o
Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/src/PathfindingA/StarNode.cpp.o
Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/build.make
Proyecto_II_Datos_II: CMakeFiles/Proyecto_II_Datos_II.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_5) "Linking CXX executable Proyecto_II_Datos_II"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/Proyecto_II_Datos_II.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/Proyecto_II_Datos_II.dir/build: Proyecto_II_Datos_II

.PHONY : CMakeFiles/Proyecto_II_Datos_II.dir/build

CMakeFiles/Proyecto_II_Datos_II.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/Proyecto_II_Datos_II.dir/cmake_clean.cmake
.PHONY : CMakeFiles/Proyecto_II_Datos_II.dir/clean

CMakeFiles/Proyecto_II_Datos_II.dir/depend:
	cd /home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/joel/Escritorio/Proyecto_II_Datos_II /home/joel/Escritorio/Proyecto_II_Datos_II /home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug /home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug /home/joel/Escritorio/Proyecto_II_Datos_II/cmake-build-debug/CMakeFiles/Proyecto_II_Datos_II.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/Proyecto_II_Datos_II.dir/depend

